<?php
session_start();
$count = &$_SESSION["count"];
echo ++$count;
