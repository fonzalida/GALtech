<?php
    class Morden extends Conectar{

      public function get_orden(){
        $conectar= parent::conexion();
        parent::set_names();
        $sql="SELECT * FROM CLIENTE";
        $sql=$conectar->prepare($sql);
        $sql->execute();
        return $resultado=$sql->fetchAll(PDO::FETCH_ASSOC);
      }

      public function get_orden_x_dni($dni){
        $conectar= parent::conexion();
        parent::set_names();
        $sql="SELECT ParteOrden.Idparte, fechaInicio, FechaFin, ParteOrden.IdOrden, Completa ,Dni ,Orden.TareaDesarrollar
        FROM ParteOrden
      INNER JOIN TecnicoOrden ON ParteOrden.IdParte = TecnicoOrden.IdParte and TecnicoOrden.Dni = ? and ParteOrden.Completa = 1
        INNER JOIN Orden ON ParteOrden.IdOrden = Orden.IdOrden";
        $sql=$conectar->prepare($sql);
        $sql->bindValue(1,$dni);
        $sql->execute();
        return $resultado=$sql->fetchAll(PDO::FETCH_ASSOC);
      }


    }

 ?>
