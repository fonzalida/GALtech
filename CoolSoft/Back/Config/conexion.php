<?php

    session_start();

    class Conectar{
      protected $dbh;

      protected function Conexion(){
            try {
              $conectar = $this->dbh = new PDO("mysql:local=localhost;dbname=biosgastro", "root","");
              return $conectar;

            } catch (Exception $e) {
              print "Error Base de Datos!". $e->getMessage(). "<br/>";
              die();
            }

      }

      public function set_names(){
        return $this->dbh->query("SET NAMES 'URF8'");
      }

      public function ruta(){
        return "http://localhost/GALtech/";
      }
    }
 ?>
