'use strict';
app.controller('FatigueReportController', ['$scope', '$rootScope', '$window', 'flightService', '$timeout', function ($scope, $rootScope, $window, flightService, $timeout) {

    $scope.isFullScreen = true;

    $scope.entity = {
        Exhausted: false,
        Fidgeting: false,
        ImpairedAttention: false,
        RubbingEyes: false,
        ImpairedMemory: false,
        Yawing: false,
        ImpairedProblemSolving: false,
        ImpairedSituationalAwareness: false,
        IncreasedRiskTaking: false,
        DifficultyKeepingEyes: false,
        FrequentBlinking: false,
        StaringBlankly: false,
        LongBlinks: false,
        NegativeMood: false,
        DifficultyKeepingEyes: false,
        ReducedCommunication: false,
        HeadNodding: false,
        FullyAlert: false,
        Lively: false,
        Fresh: false,
        LittleTired: false,
        AlmostTired: false,
        VeryTired: false,
        State: null,
        FollowUP: null,
        Day: false,
        Night: false
    }

    $scope.onLongPress = function ()
    {
        alert("test test");
    }

    $scope.popup_add_visible = false;
    $scope.popup_height = $(window).height() - 300;
    $scope.popup_width = $(window).width() - 0;
    $scope.popup_add_title = 'Fatigue Report';
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

        flightService.getFatigue($scope.tempData.FlightId).then(function (response) {
            $scope.entity = response.Result.Data;
            console.log(response.Result.Data);
            $scope.loadingVisible = false;
        })




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

    $scope.txt_reporterName = {
        bindingOptions: {
            value: "entity.ReporterName"
        }
    }

    $scope.txt_rank = {
        bindingOptions: {
            value: "entity.Rank"
        }
    }

    $scope.txt_posInFlight = {
        bindingOptions: {
            value: "entity.PositionInFlight"
        }
    }
    $scope.txt_maxDuty = {
        bindingOptions: {
            value: "entity.MaxDuty"
        }
    }
    $scope.txt_totalDuty = {
        bindingOptions: {
            value: "entity.TotalDuty"
        }
    }
    $scope.txt_reqRest = {
        bindingOptions: {
            value: "entity.RequiredRest"
        }
    }
    $scope.txt_actRest = {
        bindingOptions: {
            value: "entity.ActualRest"
        }
    }

    $scope.txt_fidgeting = {
        bindingOptions: {
            value: "entity.Fidgeting"
        }
    }

    $scope.txt_attention = {
        bindingOptions: {
            value: "entity.ImpairedAttention"
        }
    }

    $scope.txt_rubbingEyes = {
        bindingOptions: {
            value: "entity.RubbingEyes"
        }
    }

    $scope.txt_memory = {
        bindingOptions: {
            value: "entity.ImpairedMemory"
        }
    }

    $scope.txt_yawing = {
        bindingOptions: {
            value: "entity.Yawing"
        }
    }

    $scope.txt_problemSolving = {
        bindingOptions: {
            value: "entity.ImpairedProblemSolving"
        }
    }

    $scope.txt_blinking = {
        bindingOptions: {
            value: "entity.FrequentBlinking"
        }
    }

    $scope.txt_riskTaking = {
        bindingOptions: {
            value: "entity.IncreasedRiskTaking"
        }
    }

    $scope.txt_staringBlankly = {
        bindingOptions: {
            value: "entity.StaringBlankly"
        }
    }

    $scope.txt_awareness = {
        bindingOptions: {
            value: "entity.ImpairedSituationalAwareness"
        }
    }

    $scope.txt_longBlinks = {
        bindingOptions: {
            value: "entity.LongBlinks"
        }
    }

    $scope.txt_negativeMood = {
        bindingOptions: {
            value: "entity.NegativeMood"
        }
    }

    $scope.txt_keepingEyes = {
        bindingOptions: {
            value: "entity.DifficultyKeepingEyes"
        }
    }

    $scope.txt_headNodding = {
        bindingOptions: {
            value: "entity.HeadNodding"
        }
    }

    $scope.txt_reducedCommunication = {
        bindingOptions: {
            value: "entity.ReducedCommunication"
        }
    }
    $scope.txt_other = {
        bindingOptions: {
            value: "entity.Other"
        }
    }


    $scope.txt_fullyAlert = {
        bindingOptions: {
            value: "entity.FullyAlert"
        }
    }

    $scope.txt_Lively = {
        bindingOptions: {
            value: "entity.Lively"
        }
    }

    $scope.txt_Fresh = {
        bindingOptions: {
            value: "entity.Fresh"
        }
    }

    $scope.txt_littleTired = {
        bindingOptions: {
            value: "entity.LittleTired"
        }
    }

    $scope.txt_almostTired = {
        bindingOptions: {
            value: "entity.AlmostTired"
        }
    }

    $scope.txt_veryTired = {
        bindingOptions: {
            value: "entity.VeryTired"
        }
    }

    $scope.txt_exhausted = {
        bindingOptions: {
            value: "entity.Exhausted"
        }
    }

    $scope.txt_report = {
        bindingOptions: {
            value: "entity.Report"
        }
    }

    $scope.txt_state = {
        bindingOptions: {
            value: "entity.State"
        }
    }

    $scope.txt_followUp = {
        bindingOptions: {
            value: "entity.FollowUp"
        }
    }

    $scope.txt_sector = {
        bindingOptions: {
            value: "entity.Sector"
        }
    }

    $scope.txt_register = {
        bindingOptions: {
            value: "entity.Register"
        }
    }

    $scope.txt_flightNo = {
        bindingOptions: {
            value: "entity.FlightNumber"
        }
    }

    
    $scope.txt_route = {
        bindingOptions: {
            value:"getRoute(entity.FromAirportIATA,entity.ToAirportIATA)" //"entity.FromAirportIATA" + " - " + "entity.ToAirportIATA"
        }
    }
    $scope.getRoute = function (from, to) {
        return from + '-' + to;
    }

    $scope.txt_day = {
        bindingOptions: {
            value: "entity.Day"
        }
    }

    $scope.txt_night = {
        bindingOptions: {
            value: "entity.Night"
        }
    }

    $scope.txt_utcDate = {
        type: 'date',
        value: Date.now(),
    }

    $scope.txt_utcTime = {
        type: 'time',
        value: Date.now(),
    }

    $scope.txt_date = {
        type: 'date',
        value: Date.now(),
    }




    /////////////////////////////

    $scope.$on('InitFatigueReport', function (event, prms) {

        $scope.tempData = null;



        $scope.tempData = prms;


        $scope.popup_add_visible = true;

    });


}]);