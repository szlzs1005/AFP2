const express = require('express');
const connection = require('./connection');
const hashRoute = require('./routes/hash');
const app = express();
app.use(express.urlencoded({extended: true}));
app.use(express.json());
app.use('/hash',hashRoute);
module.exports = app;