<?php
header("Content-Type: text/plain");

$o = fopen("php://input", "rb");
$json = stream_get_contents($o);
fclose($o);

$obj = json_decode($json);

if(isset($obj->username, $obj->password)){
	if($obj->username == "FakeAccount" && $obj->password == "FakePassword"){
		echo "AVB89-QQRT7-PO34R-0024H-KKL56";
	}else{
		echo "Wrong username  - " . uniqid();
	}
}else{
	echo "no key found  - " . uniqid();
}

?>