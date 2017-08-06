/// <reference path="E:\users\ramprit\documents\visual studio 2017\Projects\WebApiAngular4\WebApplication.UI\Scripts/angular.js" />

'use strict';

"use strict";
app.controller("EmployeeController",
                 ["employeeResource", "$scope",
                     EmployeeController]);
function EmployeeController(employeeResource, $scope) {
    $scope.title = 'welcome to Employee portal !';
    employeeResource.query(function (data) {
        $scope.products = data;
    });
}
