<?php
    class Morden extends Conectar{
      public function get_orden(){
        $conectar= parent::conexion();
        parent::set_names();
        $sql="SELECT * FROM CLIENTE";
        $sql=$conectar->prepare($sql);
        $sql->execute();
        return $resultado=$sql->fetchAll();
      }
    }

 ?>
