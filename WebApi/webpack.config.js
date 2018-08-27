const path = require('path');

module.exports = {
    entry: ['./Scripts/es6/main.js'],
    output: {
        path: path.resolve(__dirname, './Scripts/build/'),
        filename: 'bundle.js'
    },

    module: {
        rules: [
            {
                test: /\.scss$/,
                use: [
                    "style-loader", // creates style nodes from JS strings
                    "css-loader", // translates CSS into CommonJS
                    "sass-loader" // compiles Sass to CSS, using Node Sass by default
                ]
            },
            {
                test: /\.css$/,
                use: ['style-loader', 'css-loader']
            },
            {
                test: /\.js$/,
                exclude: /node_modules/,
                use: {
                    loader: "babel-loader",
                    options: {
                        presets: ['env']
                    }
                }
            }
        ]
    }
}