window._ = require('lodash');

try {
    window.$ = window.JQuery = require('jquery');

    require('bootstrap-sass');
} catch (e) { }