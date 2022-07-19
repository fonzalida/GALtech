<?php

class Mcliente extends CI_Model{

    //MOSTRAR Cliente
    public function mselectcliente(){
        $this->db->where('estado <=','2');
        $this->db->order_by("IdCliente", "asc");
        $resultado =$this->db->get('cliente');

        return $resultado->result();
    }
    //INSERTAR Cliente
    public function minsertcliente($data){
        return  $this->db->insert('cliente',$data);
    }

    //OBTENER DATOS
    public function midupdatecliente($id){
       $this->db->where('IdCliente', $id);
       $resultado = $this->db->get('cliente');
       return $resultado->row();
    }

    //MODIFICAR Cliente
    public function mupdatecliente($id, $data){
        $this->db->where('IdCliente', $id);
        return $this->db->update('cliente', $data);
     }
     //Traer Cliente
    public function mselectinfocliente($id){
        $this->db->where('IdCliente =',"$id");
        $resultado =$this->db->get('cliente');
        return $resultado->row();
    }
}
?>
