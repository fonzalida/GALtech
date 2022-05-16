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

      public function update_parte_orden($FechaInicio, $FechaFin ,$TareaDesarrollada ,$IdParte,$Completada ,$IdOrden){
        $conectar= parent::conexion();
        parent::set_names();
        $sql="UPDATE biosgastro.parteorden
              SET FechaInicio=?, FechaFin= ?,
              TareaDesarrollada=?, Completa=1
              WHERE IdParte= ?";
        $sql=$conectar->prepare($sql);
        $sql->bindValue(1,$FechaInicio);
        $sql->bindValue(2,$FechaFin);
        $sql->bindValue(3,$TareaDesarrollada);
        $sql->bindValue(4,$IdParte);
        $sql->execute();
        $result=$this->update_orden($Completada ,$IdOrden);
        return $resultado=$sql->fetchAll(PDO::FETCH_ASSOC);
      }

      public function update_orden($Completada ,$IdOrden){
        $conectar= parent::conexion();
        parent::set_names();
        $sql="UPDATE biosgastro.orden
              SET Completada=?
              WHERE IdOrden=?";
        $sql=$conectar->prepare($sql);
        $sql->bindValue(1,$Completada);
        $sql->bindValue(2,$IdOrden);
        $sql->execute();


        return $resultado=$sql->fetchAll(PDO::FETCH_ASSOC);
      }

      public function get_tecnico($dni){
        $conectar= parent::conexion();
        parent::set_names();
        $sql="SELECT * FROM tecnico where Dni = ?";
        $sql=$conectar->prepare($sql);
        $sql->bindValue(1,$dni);
        $sql->execute();


        if($resultado=$sql->fetchAll(PDO::FETCH_ASSOC) != null ){
          return $resultado=$sql->fetchAll(PDO::FETCH_ASSOC);
        }else{
          return '0';
        }

      }


      /*
      UPDATE biosgastro.parteorden
SET FechaInicio={FechaInicio del body}, FechaFin={FechaFin del body}, TareaDesarrollada={TareaDesarrolladadel body}, Completa=1
WHERE IdParte= {IdParte del body};

UPDATE biosgastro.orden
SET Completada={Completada del body}
WHERE IdOrden={idOrden del body};
IdParte:
FechaInicio
FechaFin
TareaDesarrollada
IdOrden
Completada
*/


    }

 ?>
