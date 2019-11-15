<?php
// $start_date = "Tue, 29 Oct 2019 00:16:01 +0000";
// $start_date2 = "Tue, 29 Oct 2019 00:16:32 +0000";
// DEFINE("BC_DATE_FORMAT", "D, d M Y H:i:s O");
// $dt1 = \DateTime::createFromFormat(BC_DATE_FORMAT, $start_date, new DateTimeZone("UTC"));
// $dt2 = \DateTime::createFromFormat(BC_DATE_FORMAT, $start_date2, new DateTimeZone("UTC"));
// // echo var_dump($dt);

// //$diff = $dt2->diff($dt1, true);
// $diff2 = abs($dt2->getTimestamp() - $dt1->getTimestamp());
// echo var_dump($diff2);
use Symfony\Component\HttpFoundation\Request;
use Symfony\Component\Debug\Debug;

use App\Kernel;
use App\Utils\BigCommerceConfig;

$loader = require __DIR__.'/config/bootstrap.php';
Debug::enable();

require_once __DIR__.'/src/Kernel.php';
echo 'APP_ENV:'.$_SERVER['APP_ENV'].PHP_EOL;
echo 'APP_DEBUG:'.$_SERVER['APP_DEBUG'].PHP_EOL;

$kernel = new Kernel($_SERVER['APP_ENV'], (bool) $_SERVER['APP_DEBUG']);


//$request = Request::createFromGlobals();
$request = Request::create(
    '/hello',
    'GET',
    ['name' => 'Fabien']
);
$request->overrideGlobals();

$response = $kernel->handle($request);
$response->send();
$kernel->terminate($request, $response);


// echo "dir:".__DIR__.PHP_EOL;


