https://community.postman.com/t/is-it-possible-to-execute-an-external-program-from-postman/5693

Is it possible to execute an external program from Postman?

const http = require('http'),
  { exec } = require('child_process');

http.createServer((req, res) => {
  // Give the path of your bat or exe file
  exec('test.bat', (err, stdout, stderr) => {
    console.log({ err, stdout, stderr });
    
    if (err) {
      return res.writeHead(500).end(JSON.stringify(err));
    }
    
    // Output of the script in stdout
    return res.writeHead(200).end(stdout);
  });
}).listen(3000);
And in your pre-request / test script, you can call your local server’s URL (http://localhost:3000 7 here) that will execute the batch file and return the response for you. Something like this

pm.sendRequest('http://localhost:3000', (err, response) => {
    // This will have the output of your batch file
    console.log(response.text());
})
You can execute exe files in the same way

https://stackoverflow.com/a/61401542/26877

const http = require('http'), { exec } = require('child_process');

http.createServer((req, res) => {
  // Give the path of your bat or exe file
  exec('php token.php', (err, stdout, stderr) => {
    console.log({ err, stdout, stderr });

    if (err) {
      return res.writeHead(500).end(JSON.stringify(err));
    }

    // Output of the script in stdout
    return res.writeHead(200).end(stdout);
  });
}).listen(8000);
console.log('Server running at http://127.0.0.1:8000/');

in postman

pm.variables.set("password", "AwErFEinDqiOvXFx2wVgHvt+Rpo0jdoTH0D0QldS");

console.log("password: ", pm.variables.get("password"));

pm.sendRequest('http://127.0.0.1:8000', (err, response) => {
    // This will have the output of your batch file
    console.log(response.text());
    pm.variables.set("token", response.text());
})
