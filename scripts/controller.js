(function () {
    //Log In page Controller
    angular
        .module('app', [])
        .controller('controller', function controller($scope,$window) {
            /* jshint validthis:true */
            var vm = this;
            vm.title = 'COMPANY';
            $scope.name = "Enter Username";
            $scope.password = "";
            $scope.title = "PREMIUM";
            $scope.success = false;
            $scope.data = null;
            $scope.response = null;
            $scope.packet = {
                "user": $scope.name,
                "password": $scope.password

            };
            $scope.logIn = function (path) {
               // alert("ALERT WORKS");
                //  var dataval = "{name: 'asd'}";
                var username = $('#user').val();
                var password = $('#pass').val();
                  var dataval = "{username: '" + username  + "',password: '" + password + "'}";
                $.ajax({
                    type: "POST",
                    url: "Login.aspx/test",
                    data: dataval,
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function OnSuccess(response) {
                        //Fix response
                        if (response.d == "pass") {
                            //alert("Successful response: " + response.d);

                            $.ajax({
                                type: "POST",
                                url: "MemberPage.aspx",
                                data: dataval,
                                success: function (response) {
                                    alert("Data sent");
                                }
                            });

                            $window.location.href = path;


                        }
                        else {
                            alert("Invalid Username/Password");
                        }
                    },
                    failure: function (response) { alert("fail at AJAX with response: " + response.d) },
                    error: function (XMLHttpRequest, textStatus, errorThrown) {
                        alert("Request: " + XMLHttpRequest.toString() + "\n\nStatus: " + textStatus + "\n\nError: " + errorThrown);
                    }
                });
                
                    /*   
                $http({
                    method: "POST",
                    url: "UserManager.aspx/processRequest",
                    data: $scope.packet
                }).then(function Success(response) {
                    alert('$http invoked successfully!');
                }, function Error(response) {
                    alert('$http invoked unsuccessfully!');
                });
                */
               // $window.location.href = path;
                $scope.success = true;
            
            }

           
        }
        
    );

 
    //Home Page Controller

    /*
    angular.module('app', [])
            .controller("home");
            */
})();
