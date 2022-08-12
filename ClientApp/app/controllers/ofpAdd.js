﻿'use strict';
app.controller('ofpAddController', ['$scope', '$location', 'flightService', 'authService', '$routeParams', '$rootScope', '$window', '$compile', '$sce', function ($scope, $location, flightService, authService, $routeParams, $rootScope, $window, $compile, $sce) {
    $scope.isNew = true;
    $scope.isContentVisible = false;
    $scope.isFullScreen = true;
    $scope.isEditable = false;
    $scope.isLockVisible = false;
    var detector = new MobileDetect(window.navigator.userAgent);

    if (detector.mobile() && !detector.tablet())
        $scope.isFullScreen = true;

    $scope.entity = {
        Id: -1,

    };


    ////////////////////////
    $scope.bindEvents = function () {
        $("#ofp-doc").on("click", ".prop", function () {
            $('.prop').removeClass('selected');
            $(this).addClass('selected');
            $scope.propClick($(this).attr('id'), $(this).val());
        });

        $("#ofp-doc").on('focusin', ".prop", function () {
            // console.log("Saving value " + $(this).val());
            $(this).data('val', $(this).val());
        });

        $("#ofp-doc").on("change", ".prop", function () {
            var prev = $(this).data('val');
            $scope.onBlur($(this).attr('id'), $(this).val(), prev);
        });
    };
    ////////////////////////
    $scope.popup_add_visible = false;
    $scope.popup_height = '100%';
    $scope.popup_width = '100%';
    $scope.popup_add_title = 'Operational Flight Plan (2.10)';
    $scope.popup_instance = null;

    $scope.popup_add = {


        showTitle: true,

        toolbarItems: [
            {
                widget: 'dxButton', location: 'before', options: {
                    type: 'default', text: 'Sign', icon: 'fas fa-signature', onClick: function (e) {
                        if ($rootScope.getOnlineStatus()) {
                            $rootScope.checkInternet(function (st) {
                                if (st) {
                                    var data = { FlightId: $scope.entity.FlightId, documentType: 'ofp' };

                                    $rootScope.$broadcast('InitSignAdd', data);
                                }
                                else {
                                    General.ShowNotify("You are OFFLINE.Please check your internet connection", 'error');
                                }
                            });
                            //$scope.entity.Id

                        }
                        else {
                            General.ShowNotify("You are OFFLINE.Please check your internet connection", 'error');
                        }

                    }
                }, toolbar: 'bottom'
            },
            {
                widget: 'dxButton', location: 'after', options: {
                    type: 'default', text: 'Save All', icon: 'check', onClick: function (e) {
                        if (!$rootScope.getOnlineStatus()) {
                            alert('You are OFFLINE.Please check your internet connection.');
                            return;
                        }
                        $rootScope.checkInternet(function (st) {
                            if (st) {
                                $scope.bind(function () {
                                    //syncOFPProps
                                    $scope.loadingVisible = true;
                                    flightService.syncOFPProps($scope.entity.Id, true, function () { }).then(function (response2) {

                                        $scope.loadingVisible = false;
                                        General.ShowNotify(Config.Text_SavedOk, 'success');

                                    }, function (err) { $scope.loadingVisible = false; General.ShowNotify(err.message, 'error'); });
                                });
                            }
                            else {

                                alert('The application cannot connect to the Server. Please check your internet connection.');
                                return;
                            }
                        });





                    }
                }, toolbar: 'bottom'
            },
            {
                widget: 'dxButton', location: 'after', options: {
                    type: 'danger', text: 'Close', icon: 'remove', onClick: function (e) {
                        $scope.popup_add_visible = false;
                    }
                }, toolbar: 'bottom'
            }
        ],

        visible: false,
        dragEnabled: true,
        closeOnOutsideClick: false,
        onShowing: function (e) {
            $rootScope.IsRootSyncEnabled = false;
            $scope.popup_instance.repaint();


        },
        onShown: function (e) {

            if ($scope.isNew) {
                $scope.isContentVisible = true;
            }
            if ($scope.tempData != null)
                $scope.bind();


            //$("#ofp-doc").on("click", ".prop", function () {
            //    $('.prop').removeClass('selected');
            //    $(this).addClass('selected');
            //    $scope.propClick($(this).attr('id'), $(this).val());
            //});

            //$("#ofp-doc").on("change", ".prop", function () {

            //    $scope.onBlur($(this).attr('id'), $(this).val());
            //});
            $scope.bindEvents();

        },
        onHiding: function () {
            $rootScope.IsRootSyncEnabled = true;
            $("#ofp-doc")
                .off("click", ".prop");
            $("#ofp-doc")
                .off("change", ".prop");
            $scope.props = [];
            $scope.OFPHtml = '';
            $scope.popup_add_visible = false;
            //$rootScope.$broadcast('onDrAddHide', null);
        },
        onContentReady: function (e) {
            if (!$scope.popup_instance)
                $scope.popup_instance = e.component;

        },
        bindingOptions: {
            visible: 'popup_add_visible',
            fullScreen: 'isFullScreen',
            title: 'popup_add_title',
            height: 'popup_height',
            width: 'popup_width',
            'toolbarItems[1].visible': 'isEditable',
            'toolbarItems[0].visible': 'isLockVisible',

        }
    };

    $scope.propType = 'number';
    $scope.propValueStr = null;
    $scope.propValueNum = null;
    $scope.propName = null;
    $scope.props = [];
    $scope.txtIns = null;
    $scope.txt_prop = {
        onInitialized: function (e) {
            if (!$scope.txtIns)
                $scope.txtIns = e.component;
            //setTimeout(function () {
            //    e.component.focus();
            //}, 0);
        },
        bindingOptions: {
            value: 'propValueStr',
        }
    };
    $scope.num_prop = {
        bindingOptions: {
            value: 'propValueNum',
        }
    };

    $scope.popup_value_instance = null;
    $scope.popup_value_visible = false;
    $scope.popup_value = {

        shadingColor: 'rgba(255,255,255,0.1)',
        showTitle: true,

        toolbarItems: [

            {
                widget: 'dxButton', location: 'after', options: {
                    type: 'default', text: 'Save', icon: 'check', onClick: function (e) {

                        var dto = { OFPId: $scope.entity.Id, PropName: $scope.propName, User: $rootScope.userTitle };
                        if ($scope.propType == 'number') {
                            if ($scope.propValueNum === 0)
                                dto.PropValue = '0';
                            else
                                dto.PropValue = $scope.propValueNum ? $scope.propValueNum.toString() : '...';
                        }
                        else {
                            dto.PropValue = $scope.propValueStr ? $scope.propValueStr : '...';
                        }
                        $scope.loadingVisible = true;
                        flightService.saveOFPProp(dto).then(function (response2) {

                            $scope.loadingVisible = false;
                            // General.ShowNotify(Config.Text_SavedOk, 'success');
                            $('#' + $scope.propName).html(dto.PropValue);
                            $scope.popup_value_visible = false;

                        }, function (err) { $scope.loadingVisible = false; General.ShowNotify(err.message, 'error'); });
                        //if (!result.isValid) {
                        //    General.ShowNotify(Config.Text_FillRequired, 'error');
                        //    return;
                        //}

                        //$scope.loadingVisible = true;
                        //flightService.saveDR($scope.entity).then(function (response2) {
                        //    $scope.loadingVisible = false;
                        //    if (response2.IsSuccess) {
                        //        General.ShowNotify(Config.Text_SavedOk, 'success');
                        //        console.log('DR', response2.Data);
                        //        $scope.popup_add_visible = false;
                        //    }


                        //}, function (err) { $scope.loadingVisible = false; General.ShowNotify(err.message, 'error'); });



                    }
                }, toolbar: 'bottom'
            },
            {
                widget: 'dxButton', location: 'after', options: {
                    type: 'danger', text: 'Close', icon: 'remove', onClick: function (e) {
                        $scope.popup_value_visible = false;
                    }
                }, toolbar: 'bottom'
            }
        ],
        // position:'left top',
        //position: { my: 'right', at: 'right', of: window, offset: '-15 0' },
        position: {
            my: "right top",
            at: "right top",
            offset: '-15 60'
        },
        visible: false,
        dragEnabled: true,
        closeOnOutsideClick: false,
        onShowing: function (e) {
            $scope.popup_instance.repaint();
        },
        onShown: function (e) {
            $scope.txtIns.focus();
        },
        onHiding: function () {
            $('.prop').removeClass('selected');
            $scope.propType = 'number';
            $scope.propValueStr = null;
            $scope.propValueNum = null;
            $scope.propName = null;

            $scope.popup_value_visible = false;

        },
        onContentReady: function (e) {
            if (!$scope.popup_value_instance) {
                $scope.popup_value_instance = e.component;
            }
        },
        title: 'Value',
        height: 200,
        width: 300,
        bindingOptions: {
            visible: 'popup_value_visible',


        }
    };

    /////////////////////////////////
    function _replaceAll(str, find, replace) {
        return str.replace(new RegExp(find, 'g'), replace);
    }
    $scope.flight = null;
    var _toNum = function (v) {
        try {
            return !v ? 0 : Number(v);
        }
        catch (e) {
            return 0;
        }
    };
    var momentUtcNowStringSecond = function () {
        return moment.utc().format('YYYYMMDDHHmmss');
    };
    $scope.updateValue = function (propId, value) {
        //12-04
        
        if (propId == sobId) {
            
            return;
        }


        //if (propId == 'prop_cptgnd') {
        //    //db.updateRVSM($scope.flight.FlightId, "RVSM_GND_CPT", value);
        //    var mt = momentUtcNowStringSecond();
        //   var changes = { RVSM_GND_CPT: value, RVSM_GND_CPTDt:mt, Version: $scope.flight.Version, JLDate: momentFromatLocalUTC($scope.flight.JLDate), JLUserId: $rootScope.employeeId, };

        //    flightService.saveFlightProp($scope.flight, 'RVSM_GND_CPT', value, mt, $scope.flight.Version,changes);
        //}

        var dto = { OFPId: $scope.entity.Id, PropName: propId, User: $rootScope.userTitle };

        dto.PropValue = value;
       // $scope.loadingVisible = true;
        flightService.saveOFPProp(dto).then(function (response2) {

           // $scope.loadingVisible = false;

            if (propId == crewAId || propId == crewBId || propId == crewCId
                /*|| propId == 'prop_pax_adult' || propId == 'prop_pax_child' || propId == 'prop_pax_infant'*/
            ) {
                var crewpax = _toNum($('#' + crewAId).val()) + _toNum($('#' + crewBId).val()) + _toNum($('#' + crewCId).val());
                crewpax += _toNum($('#prop_pax_adult').val()) + _toNum($('#prop_pax_child').val()) + _toNum($('#prop_pax_infant').val());
                if (isNaN(crewpax))
                    crewpax = '';
                $('#' + sobId).val(crewpax);


                $scope.onBlur(sobId, crewpax);
            } 

        }, function (err) {

                $scope.loadingVisible = false; General.ShowNotify(JSON.stringify(err), 'error');
        });
    };
    //12-04
    $scope.onBlur = function (propId, value, prev) {
        //$("#ofp-doc")
        //    .off("click", ".prop");
        //$("#ofp-doc")
        //    .off("change", ".prop");
        //console.log('propid:  ' + propId);
       // console.log('old:  ' + prev);
        //console.log('new:  ' + value);
        var _v = (value === undefined || (!value && value!==0))?value:  value.toString().replace(/\s/g, '');
        if ((!_v && _v !== 0) || _v === undefined) { 
            $('#' + propId).val(prev);
            return;

            //General.Confirm("The selected field will be cleared. Are you sure? (Current value: "+prev+")", function (res) {
            //    if (res) {
            //        $scope.updateValue(propId, value);

            //    }
            //    else {
            //        $('#' + propId).val(prev);
            //        return;
            //    }
            //});
        }
        else {

            $scope.updateValue(propId, value);
        }


    };
    $scope.propClick = function (propId, value) {
        return;


        $scope.$apply(function () {
            value = _replaceAll(value, ' ', '');


            $scope.propName = propId;
            $scope.propType = 'number';
            //if (propId.startsWith('prop_ofbcpt'))
            //    $scope.propType = 'string';
            //if (propId.startsWith('prop_ofbfo'))
            //    $scope.propType = 'string';
            //if (propId.startsWith('prop_clearance'))
            //    $scope.propType = 'string';



            //if ($scope.propType == 'string')
            //    $scope.propValueStr = value;
            //else
            //    $scope.propValueNum = value;
            $scope.propType = 'string';
            $scope.propValueStr = value;
            // $scope.popup_value_visible = true;
            // alert($scope.propName);
        });

    };
    //$scope.propClick = function (event) {
    //    alert('x  '+ $(event.target).attr("id") ); 
    //};
    $scope.OFPHtml = '';
    var crewAId = null;
    var crewBId = null;
    var crewCId = null;
    var sobId = null;
    $scope.fill = function (data, callback) {
        $scope.entity = data;

        $scope.OFPHtml = $sce.trustAsHtml($scope.entity.TextOutput);

        setTimeout(function () {
            //'prop_pax_adult', 'prop_pax_child', 'prop_pax_infant'

            $('#prop_pax_adult').attr('readonly', true).addClass('noborder');
            $('#prop_pax_child').attr('readonly', true).addClass('noborder');
            $('#prop_pax_infant').attr('readonly', true).addClass('noborder');
            $('#prop_offblock').attr('readonly', true);
            $('#prop_takeoff').attr('readonly', true);
            $('#prop_landing').attr('readonly', true);
            $('#prop_onblock').attr('readonly', true);
            $('#prop_reqfuel').attr('readonly', true);


            var $clear = $("input[id^='prop_clearance']");
            $clear.width(600);
            //$('#prop_pax_infant').nextAll('.prop:first');
            var $adult = $clear.nextAll('.prop:first');
            crewAId = $adult.attr('id');

            var $child = $adult.nextAll('.prop:first');
            crewBId = $child.attr('id');

            var $infant = $child.nextAll('.prop:first');
            crewCId = $infant.attr('id');

            var $sob = $('#prop_pax_infant').nextAll('.prop:first');
            sobId = ($sob.attr('id'));
            callback();

        }, 100);

        //  $compile($("#ofp-doc").contents())($scope);
        //alert('x');

        //alert('init');
        //flightService.saveOFPProp({ OFPId: 10, PropName: 'dool', PropValue: 'vahid10', User: $rootScope.userTitle}).then(function (response2) {

        //    alert('saved');


        //}, function (err) { $scope.loadingVisible = false; General.ShowNotify(err.message, 'error'); });


    };
    $scope.isLockVisible = false;

    var toTime = function (dt) {
        if (!dt)
            return "";

        var result = moment(new Date(dt)).format('HHmm');
         


        return moment(new Date(dt)).format('HHmm');
    };
    function parseISOString(s) {
        s = s.toString();
        var prts = s.split('T');
        var dts = prts[0].split('-');
        var tms = prts[1].split(':');
        var dt = new Date(dts[0], dts[1] - 1, dts[2], tms[0], tms[1], tms[2]);
        // var b = s.split(/\D+/);
        // return new Date(Date.UTC(b[0], --b[1], b[2], b[3], b[4], b[5], b[6]));
        return dt;
    }

    $scope.checkSign = function (ofpid, flightid) {
         
        console.log('check sign');
        flightService.getOFPCheckSign(ofpid).then(function (data) {
            if (data && data.JLSignedBy) {
                $scope.url_sign = signFiles + data.JLSignedBy + ".png";
                 
                $scope.PIC = data.PIC;
                $scope.signDate = moment(new Date(data.JLDatePICApproved)).format('YYYY-MM-DD HH:mm');
                $('#sig_pic_img').attr('src', $scope.url_sign);

                flightService.signOFPLocal(flightid, data);
            }
        });
    };
    $scope.dr = null;
    $scope.bind = function (callback) {

        $scope.entity.FlightId = $scope.tempData.FlightId;

        //if ($rootScope.getOnlineStatus()) {

        //    flightService.checkLock($scope.entity.FlightId, 'ofp').then(function (response) {
        //        $scope.isLockVisible = false;
        //        if (response.IsSuccess && response.Data.canLock) {
        //            $scope.isLockVisible = true;
        //        }
        //    }, function (err) { });
        //}

        $scope.loadingVisible = true;

        flightService.epGetFlightLocal($scope.entity.FlightId).then(function (response) {

            $scope.loadingVisible = false;

            $scope.loadingVisible = true;

            flightService.epGetDRByFlight($scope.entity.FlightId).then(function (resdr) {
                $scope.loadingVisible = false;
                if (resdr.Data) {
                    $scope.dr = resdr.Data;
                  //  alert($scope.dr.MinFuelRequiredPilotReq);
                }
                else {
                  //  alert('no dr');
                }
                ////////////////////////



                var diff = Math.abs((new Date()).getTime() - (new Date(response.Data.STALocal)).getTime()) / 3600000;

                $scope.flight = response.Data;

                $scope.loadingVisible = true;

                flightService.epGetOFPByFlight($scope.entity.FlightId).then(function (response2) {
                    $scope.isEditable = (diff <= 24);
                    console.log(response2.Data);
                    if (response2.Data && response2.Data.JLSignedBy) {
                        // $scope.isEditable = false;
                        $scope.url_sign = signFiles + response.Data.PICId + ".png";
                        $scope.PIC = response.Data.PIC;
                        $scope.signDate = moment(new Date(response.Data.JLDatePICApproved)).format('YYYY-MM-DD HH:mm');
                    }
                    else {
                        $scope.url_sign = null;
                        $scope.PIC = null;
                        $scope.signDate = null;
                    }

                    $scope.loadingVisible = false;





                    if (!response2.Data) {

                        $scope.isNew = true;
                        $scope.entity = {
                            Id: -1,

                        };
                        $scope.entity.FlightId = $scope.tempData.FlightId;

                    }
                    else {

                        $scope.isNew = false;
                        $scope.fill(response2.Data, function () {


                            flightService.epCheckOFBVersion($scope.entity.FlightId, $scope.entity.Id).then(function (resCheck) {
                                if (resCheck.Data) {
                                    flightService.deleteOFP($scope.entity.FlightId, function () {
                                        alert("The OPF has been changed by Dispatchers. Please reopen the from to load new OFP.");
                                        $scope.popup_add_visible = false;
                                        return;
                                    });

                                }
                                else {
                                    ////// GET PROPS ///////////////

                                    $scope.loadingVisible = true;
                                    console.log('getting props start');
                                    flightService.epGetOFPProps($scope.entity.Id).then(function (response3) {
                                        try {

                                            $scope.loadingVisible = false;


                                            //12-04

                                            if (!$scope.url_sign)
                                                $scope.checkSign($scope.entity.Id, $scope.entity.FlightId);
                                             $('#sig_disp_img').attr('src', signFiles+$scope.entity.User +".png");
                                            // $scope.url_sign = signFiles + response.Data.PICId + ".png";



                                            console.log('props got');
                                            $scope.props = response3.Data;
                                            $('.prop').html(' ');

                                            //9-11
                                            var updates = [];
                                            var takeOffChanged = false;
                                            var sob = 0;
                                            var sobValue = null;
                                            var sobprops = ['prop_pax_adult', 'prop_pax_child', 'prop_pax_infant', crewAId, crewBId, crewCId];


                                            //here
                                            $.each($scope.props, function (_i, _d) {

                                                if (_d.PropName == sobId) {

                                                    sobValue = _d.PropValue;
                                                }


                                                if (_d.PropValue)
                                                    $('#' + _d.PropName).val(_d.PropValue);
                                                if (_d.PropName == 'prop_reqfuel' && $scope.dr) {
                                                    $('#' + _d.PropName).val($scope.dr.MinFuelRequiredPilotReq);
                                                    updates.push({ OFPId: $scope.entity.Id, PropName: _d.PropName, User: $rootScope.userTitle, PropValue: $scope.flight.PaxAdult });
                                                }

                                                if (_d.PropName == 'prop_pax_adult' /*&& $scope.flight.PaxAdult != _d.PropValue*/) {
                                                    $('#' + _d.PropName).val($scope.flight.PaxAdult);
                                                    updates.push({ OFPId: $scope.entity.Id, PropName: _d.PropName, User: $rootScope.userTitle, PropValue: $scope.flight.PaxAdult });
                                                    //var dto = { OFPId: $scope.entity.Id, PropName: _d.propName, User: $rootScope.userTitle, PropValue: $scope.flight.PaxAdult };
                                                    //flightService.saveOFPProp(dto);
                                                }
                                                if (_d.PropName == 'prop_pax_child' /*&& $scope.flight.PaxChild != _d.PropValue*/) {
                                                    $('#' + _d.PropName).val($scope.flight.PaxChild);
                                                    updates.push({ OFPId: $scope.entity.Id, PropName: _d.PropName, User: $rootScope.userTitle, PropValue: $scope.flight.PaxChild });
                                                }
                                                if (_d.PropName == 'prop_pax_infant' /*&& $scope.flight.PaxInfant != _d.PropValue*/) {
                                                    $('#' + _d.PropName).val($scope.flight.PaxInfant);
                                                    updates.push({ OFPId: $scope.entity.Id, PropName: _d.PropName, User: $rootScope.userTitle, PropValue: $scope.flight.PaxInfant });
                                                }
                                                //prop_offblock

                                                if (_d.PropName == 'prop_offblock' /*&& toTime(CreateDate($scope.flight.BlockOff)) != _d.PropValue*/) {
                                                    $('#' + _d.PropName).val(toTime(CreateDate($scope.flight.BlockOff)));
                                                    updates.push({ OFPId: $scope.entity.Id, PropName: _d.PropName, User: $rootScope.userTitle, PropValue: toTime(CreateDate($scope.flight.BlockOff)) });
                                                }
                                                //prop_takeoff
                                                if (_d.PropName == 'prop_takeoff' /*&& toTime(CreateDate($scope.flight.TakeOff)) != _d.PropValue*/) {
                                                    takeOffChanged = true;
                                                    $('#' + _d.PropName).val(toTime(CreateDate($scope.flight.TakeOff)));
                                                    updates.push({ OFPId: $scope.entity.Id, PropName: _d.PropName, User: $rootScope.userTitle, PropValue: toTime(CreateDate($scope.flight.TakeOff)) });
                                                }
                                                //prop_landing
                                                if (_d.PropName == 'prop_landing' /*&& toTime(CreateDate($scope.flight.Landing)) != _d.PropValue*/) {
                                                    $('#' + _d.PropName).val(toTime(CreateDate($scope.flight.Landing)));
                                                    updates.push({ OFPId: $scope.entity.Id, PropName: _d.PropName, User: $rootScope.userTitle, PropValue: toTime(CreateDate($scope.flight.Landing)) });
                                                }
                                                //prop_onblock
                                                if (_d.PropName == 'prop_onblock' /*&& toTime(CreateDate($scope.flight.BlockOn)) != _d.PropValue*/) {
                                                    $('#' + _d.PropName).val(toTime(CreateDate($scope.flight.BlockOn)));
                                                    updates.push({ OFPId: $scope.entity.Id, PropName: _d.PropName, User: $rootScope.userTitle, PropValue: toTime(CreateDate($scope.flight.BlockOn)) });
                                                }

                                                if (sobprops.indexOf(_d.PropName) != -1) {
                                                    var vlu = _toNum($('#' + _d.PropName).val());
                                                    if (!isNaN(vlu))
                                                        sob += vlu;
                                                }

                                            });

                                            if (sob != sobValue) {
                                                $('#' + sobId).val(sob);
                                                updates.push({ OFPId: $scope.entity.Id, PropName: sobId, User: $rootScope.userTitle, PropValue: sob });
                                            }
                                            if (takeOffChanged && $scope.flight.TakeOff) {
                                                var times = $("input[data-info^='time_']");
                                                var objs = [];
                                                $.each(times, function (_w, _t) {
                                                    var data = $(_t).data('info');
                                                    objs.push({ id: $(_t).attr('id'), index: Number(data.split('_')[1]), value: data.split('_')[2] });
                                                });
                                                objs = Enumerable.From(objs).OrderBy('$.index').ToArray();
                                                var to = CreateDate($scope.flight.TakeOff);
                                                $.each(objs, function (_w, _t) {
                                                    to = new Date(to.addMinutes(_t.value));
                                                    $('#' + _t.id).val(toTime(to));
                                                    $('#' + _t.id).attr('readonly', true).addClass('noborder');
                                                    //  updates.push({ OFPId: $scope.entity.Id, PropName: _t.id, User: $rootScope.userTitle, PropValue: toTime(to) });
                                                });
                                            }

                                            //if (updates.length > 0)
                                            //    flightService.saveOFPPropBulk(updates, $scope.entity.Id); 
                                            if ($scope.url_sign)
                                                $('#sig_pic_img').attr('src', $scope.url_sign);
                                            //here





                                            //  $('#sig_disp_img').attr('src', signFiles + '3542.jpg');

                                            //  $('#sig_pic_img').attr('src', signFiles + '3542.jpg');

                                        }
                                        catch (e) {
                                            alert(e);
                                        }

                                    }, function (err) { $scope.loadingVisible = false; General.ShowNotify(err.message, 'error'); });

                                    ////////// END OF GET PROPS //////////////

                                }

                                ////// END OF OFP VERSION CHECK /////////////
                            });



                        });


                    }

                    //console.log('ASR',response2.Data);
                    if (callback)
                        callback();

                }, function (err) { $scope.loadingVisible = false; General.ShowNotify(err.message, 'error'); });






                //end of get dr
            }, function (err) { $scope.loadingVisible = false; General.ShowNotify(err.message, 'error'); });


          



        }, function (err) { $scope.loadingVisible = false; General.ShowNotify(err.message, 'error'); });
    };
    ////////////////////////////////
    $scope.scroll_dradd_height = $(window).height() - 100;
    var appWindow = angular.element($window);
    appWindow.bind('resize', function () {
        //alert('w: '+$(window).width());

        $scope.$apply(function () {
            $scope.scroll_dradd_height = $(window).height() - 100;
        });
    });
    $scope.scroll_dradd = {
        width: '100%',
        bounceEnabled: false,
        showScrollbar: 'never',
        pulledDownText: '',
        pullingDownText: '',
        useNative: true,
        refreshingText: 'Updating...',
        onPullDown: function (options) {

            options.component.release();

        },
        onInitialized: function (e) {


        },
        bindingOptions: {
            height: 'scroll_dradd_height'
        }

    };
    /////////////////////////////////
    $scope.tempData = null;
    $scope.$on('onSign', function (event, prms) {

        if (prms.doc == 'ofp')
            flightService.signDocLocal(prms, prms.doc).then(function (response) {

                // $scope.isEditable = false;
                //$scope.isLockVisible = false;
                $scope.url_sign = signFiles + prms.PICId + ".png";
                $scope.PIC = prms.PIC;
                $scope.signDate = moment(new Date(prms.JLDatePICApproved)).format('YYYY-MM-DD HH:mm');
                if ($scope.url_sign)
                    $('#sig_pic_img').attr('src', $scope.url_sign);
            }, function (err) { $scope.loadingVisible = false; General.ShowNotify(err.message, 'error'); });

    });
    $scope.$on('InitOFPAdd', function (event, prms) {



        $scope.tempData = null;

        $scope.tempData = prms;


        $scope.popup_add_visible = true;

    });

}]);