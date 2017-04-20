angular.module('BenefitsApp', [])
    .controller('BenefitsController', function ($scope, $http) {

        $scope.greeting = "Your Benefits";
        $scope.people = null;
        $scope.monthlyCost = 1001.00;

        $scope.init = function () {

            $http({
                method: 'GET',
                url: '/api/people'
            }).then(function successCallback(response) {
                $scope.people = response.data;
            }, function errorCallback(response) {
                console.log("Error: " + response);
            });
        };

        $scope.add = function () {
            $scope.people.push({ 'birthday':'01/01/1999', 'relation':'Select' });
        };

        $scope.calculate = function () {

        };

        $scope.updateRelation = function (person, relation) {
            person.relation = relation;
        };

        $scope.init();
    });