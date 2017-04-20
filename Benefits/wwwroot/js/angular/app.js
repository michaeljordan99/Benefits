angular.module('BenefitsApp', ['ngAnimate'])
    .controller('BenefitsController', function ($scope, $http) {

        $scope.people = null;
        $scope.peopleCosts = null;
        $scope.monthlyCost = 0;
        $scope.annualCost = 0;
        $scope.paycheckCost = 0;
        $scope.annualSalaryAfterDeductions = 0;

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

        $scope.remove = function (index) {
            $scope.people.splice(index, 1);
            if ($scope.peopleCosts !== null) $scope.calculate();
        };

        $scope.calculate = function () {

            $scope.annualCost = 0;
            $scope.monthlyCost = 0;
            $scope.paycheckCost = 0;
            $scope.annualSalaryAfterDeductions = 0;

            $scope.peopleCosts = angular.copy($scope.people);

            angular.forEach($scope.peopleCosts, function (person, key) {
                person.cost = 500;
                if (person.relation.toLowerCase() === 'employee') person.cost = 1000;
                if (person.firstName.toLowerCase().startsWith('a')) person.cost = person.cost - (person.cost * .10);
                $scope.annualCost += person.cost;
                $scope.monthlyCost = $scope.annualCost / 12;
                $scope.paycheckCost = $scope.annualCost / 26;
                $scope.annualSalaryAfterDeductions = (2000 * 26) - $scope.annualCost;
            });
        };

        $scope.updateRelation = function (person, relation) {
            person.relation = relation;
        };

        $scope.isValid = function () {
            var isValid = true;
            angular.forEach($scope.people, function (person, key) {
                if (person.firstName === undefined || person.lastName === undefined || person.relation.toLowerCase() === 'select') {
                    isValid = false;
                    return;
                }
            });
            return isValid;
        };

        $scope.init();
    });