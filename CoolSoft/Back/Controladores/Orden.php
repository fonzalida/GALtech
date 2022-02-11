<?php

    header('Content-Type: application/json');
    require_once("../Config/conexion.php");
    require_once("../Modelos/Morden.php");

    $orden = new Morden();

    $body =  json_decode(file_get_contents("php://input"),true);


    switch ($_GET["op"]) {
      case 'GetAll':
        $datos=$orden->get_orden();
        echo json_encode($datos);
        break;

      case 'GetDni':
        $datos=$orden->get_orden_x_dni($body["DNICUIT"]);
        echo json_encode($datos);
      break;

      case 'UpdateOrden':
        $datos=$orden->update_parte_orden($body["FechaInicio"],$body["FechaFin"],$body["TareaDesarrollada"],$body["IdParte"],$body["Completada"],$body["IdOrden"]);
        echo "Correcto";
      break;

      default:
        // code...
        break;
    }
 ?>
