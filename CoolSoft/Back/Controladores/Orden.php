<?php

    require_once("../Config/conexion.php");
    require_once("../Modelos/Morden.php");

    $orden = new Morden();

    switch ($_GET["op"]) {
      case 'GetAll':
        $datos=$orden->get_orden();
        echo json_encode($datos);
        break;

      default:
        // code...
        break;
    }
 ?>
