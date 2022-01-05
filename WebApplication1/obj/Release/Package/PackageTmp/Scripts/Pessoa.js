var app = angular.module('myApp', []);
app.controller('myCtrl', function ($scope, $http) {
    
    $scope.InsertPessoa = function () {
        var type = document.getElementById("insertPes").getAttribute("value");
        if (type == "Enviar") {
            $http({
                method: "POST",
                url: "https://localhost:44390/Home/InsertPessoa?Nome=" + $scope.PNome + "&Idade=" + $scope.PIdade + "&Telefone=" + $scope.PTelefone + "&Email=" + $scope.PEmail,
                datatype: "JSON",
            }).then(function (response) {
                alert(response.data);
            })
        }
    }
});