var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('BoilerplateInitiative');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);