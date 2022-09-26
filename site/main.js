const express = require('express');
const port = 3100;

const app = express();

app.get('/', (req, res) => {
    res.sendFile(__dirname + '/index.html');
})


app.listen(port, () => {console.log('[+] server started on port 3100. link: http://localhost:3100')})