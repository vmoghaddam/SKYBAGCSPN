'use strict';
app.controller('TripInfoController', ['$scope', '$rootScope', 'flightService', '$window', function ($scope, $rootScope, flightService, $window) {

    $scope.isFullScreen = false;

    $scope.entity = {
        Exhausted: false,

    }



    $scope.popup_add_visible = false;
    $scope.popup_height = $(window).height() - 300;
    $scope.popup_width = $(window).width() - 100;
    $scope.popup_add_title = 'Trip Info';
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
                                    var data = { FlightId: $scope.entity.FlightId, documentType: 'asr' };

                                    $rootScope.$broadcast('InitSignAdd', data);
                                }
                                else {
                                    General.ShowNotify("You are OFFLINE.Please check your internet connection", 'error');
                                }
                            });

                        }
                        else {
                            General.ShowNotify("You are OFFLINE.Please check your internet connection", 'error');
                        }

                    }
                }, toolbar: 'bottom'
            },

            {
                widget: 'dxButton', location: 'after', options: {
                    type: 'default', text: 'Save', icon: 'check', validationGroup: 'toadd', onClick: function (e) {



                        $scope.loadingVisible = true;

                        flightService.saveFatigue($scope.entity).then(function (response) {
                            $scope.loadingVisible = false;
                            flightService.getFatigue($scope.entity.FlightId).then(function (response2) {
                                $scope.entity = response2.Result.Data;
                            })

                        })


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
        },
        onHiding: function () {
            $rootScope.IsRootSyncEnabled = true;
            //$scope.clearEntity();
            $scope.entity = {
                Id: -1,


            };
            $scope.popup_add_visible = false;
            $rootScope.$broadcast('onFatigueReportHide', null);
        },
        onContentReady: function (e) {
            if (!$scope.popup_instance)
                $scope.popup_instance = e.component;

        },
        // fullScreen:false,
        bindingOptions: {
            visible: 'popup_add_visible',
            fullScreen: 'isFullScreen',
            title: 'popup_add_title',
            height: 'popup_height',
            width: 'popup_width',
            'toolbarItems[1].visible': 'isLockVisible',
            'toolbarItems[2].visible': 'isEditable',

        }
    };

    ////////////////////////////


    $scope.bind = function () {



        $scope.entity.FlightId = $scope.tempData.FlightId;
        $scope.loadingVisible = true;

        flightService.getTripInfo($scope.tempData.FlightId).then(function (response) {
            $scope.entity = response.Result.Data;
            console.log(response.Result.Data);
            $scope.loadingVisible = false;
        })


        flightService.epGetFlightCrews($scope.tempData.FlightId).then(function (response) {
            $scope.loadingVisible = false;
            if (response.IsSuccess) {
                $scope.selectedFlightCrews = response.Data;

            }
            else
                $rootScope.processErorrs(response);

        }, function (err) { $scope.loadingVisible = false; General.ShowNotify(err.message, 'error'); });


    };

    ////////////////////////////

    $scope.scroll_FatigueReport_height = $(window).height() - 130;
    $scope.scroll_FatigueReport = {
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
            height: 'scroll_FatigueReport_height'
        }

    };
    var appWindow = angular.element($window);
    appWindow.bind('resize', function () {
        //alert('w: '+$(window).width());

        $scope.$apply(function () {
            $scope.scroll_FatigueReport_height = $(window).height() - 130;
        });
    });

    ////////////////////////////

    $scope.txt_flightNo = {
        bindingOptions: {
            value: "entity.FlightNumber"
        }
    }

    $scope.txt_register = {
        bindingOptions: {
            value: "entity.Register"
        }
    }

    $scope.txt_date = {
        type: 'date',
        value: Date.now()
        //bindingOptions: {
        //    value: "entity.FlightNumber"
        //}
    }

    $scope.txt_rampFuel = {
        bindingOptions: {
            value: "entity.FPFuel"
        }
    }

    $scope.txt_taxiFuel = {
        bindingOptions: {
            value: 200
        }
    }

    $scope.txt_tripFuel = {
        bindingOptions: {
            value: "entity.FlightNumber"
        }
    }

    $scope.txt_mtow = {
        bindingOptions: {
            value: "entity.mtow"
        }
    }

    //$scope.txt_crew = {
    //    bindingOptions: {
    //        value: "entity.FlightNumber"
    //    }
    //}

    //$scope.txt_fm = {
    //    bindingOptions: {
    //        value: "entity.FlightNumber"
    //    }
    //}

    //$scope.txt_dh = {
    //    bindingOptions: {
    //        value: "entity.FlightNumber"
    //    }
    //}

    //$scope.txt_cptName = {
    //    bindingOptions: {
    //        value: "entity.FlightNumber"
    //    }
    //}




    /////////////////////////////

    $scope.$on('InitTripInfo', function (event, prms) {

        $scope.tempData = null;



        $scope.tempData = prms;


        $scope.popup_add_visible = true;

    });

}]);