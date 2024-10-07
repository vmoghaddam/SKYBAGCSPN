'use strict';
app.controller('fdmSummeryController', ['$http', '$scope', '$location', '$routeParams', '$rootScope', 'flightService', 'fdmService', 'authService', 'notificationService', '$route', function ($http, $scope, $location, $routeParams, $rootScope, flightService, fdmService, authService, notificationService, $route) {

    $scope.ds = [
        { year: 2022, month: 'June', monthId: 5, title: '2022-June', },
        { year: 2022, month: 'July', monthId: 6, title: '2022-July', },
        { year: 2022, month: 'August', monthId: 7, title: '2022-August', },
        { year: 2022, month: 'September', monthId: 8, title: '2022-September', },
        { year: 2022, month: 'October', monthId: 9, title: '2022-October', },
        { year: 2022, month: 'November', monthId: 11, title: '2022-November', },
        { year: 2022, month: 'December', monthId: 1, title: '2022-December', },
        { year: 2023, month: 'January', monthId: 0, title: '2023-January', }
    ]

    $scope.itemClicked = function (year, month) {
        window.location = "#!/fdm/" + year + "/" + month;

    }
}]);
