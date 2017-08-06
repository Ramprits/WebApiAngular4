app.factory('employeeService', function ($http, $log) {

    return {
        getEvent: function (successcb) {
            $http({ method: 'GET', url: 'http://localhost:63435/api/customers' }).
                success(function (data, status, headers, config) {
                    successcb(data);
                }).
                error(function (data, status, headers, config) {
                    $log.warn(data, status, headers(), config);
                });
        }
    };
});

