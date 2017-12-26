(function () {
    angular.module('app').controller('app.views.fieldGroups.index', [
        '$scope', '$uibModal', 'abp.services.app.fieldGroup',
        function ($scope, $uibModal, fieldGroupService) {
            var vm = this;
            //About logic...
            debugger;
            function getFieldGroups() {
                fieldGroupService.getAll({}).then(function (result) {
                    vm.roles = result.data.items;
                });
            }

            getFieldGroups();
        }
    ]);
})();