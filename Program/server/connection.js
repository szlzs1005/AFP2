const mysql = require('mysql');
var connection = mysql.createConnection({
    port:3306,
    host:'localhost',
    user:'szlzs1005',
    password:'20001005',
    database:'afp2'
});

connection.connect((err) => {
    if (!err)
    {
        console.log(`Successfully connected to the database`);
    }
    else
    {
        console.log(err);
    }
});

module.exports = connection;