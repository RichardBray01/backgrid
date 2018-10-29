var path = require('path');

module.exports = {
    mode: 'development',

    entry: {
        setcontents: './src/js/setcontents.js'
    },

    output: {
        publicPath: "./js/",
        path:  path.join(__dirname, '/wwwroot/js'),
        filename: 'bundle.js'
    }
}