<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Ccliente extends CI_Controller {
    function __construct(){
    parent:: __construct();
    if(!$this->session->userdata('login')){
        redirect(base_url());
    }
    $this->load->model('mcliente');
    $this->load->model('mcombo');
    }


public function index(){
    $data = array (
        'clienteindex' => $this->mcliente->mselectcliente(),
    );
    $this->load->view('layouts/header');
    $this->load->view('layouts/aside');
    $this->load->view('admin/cliente/vlist', $data);
    $this->load->view('layouts/footer');
}


public function cadd(){
    $data = array (
        'tipoDocumentocombo' => $this->mcombo->mcombotabla('clientes'),

    );
    $this->load->view('layouts/header');
    $this->load->view('layouts/aside');
    $this->load->view('admin/cliente/vadd', $data);
    $this->load->view('layouts/footer');
}


public function cinsert(){

     $nombre = $this->input->post('txtnombre');
     $cuit = $this->input->post('txtcuit');
     $prov = $this->input->post('txtprovincia');
     $domicilio = $this->input->post('txtdomicilio');

    //REGLA DE VALIDACION
        $data = array(

            'Nombre' => $nombre,
            'DniCuit' => $cuit,
            'Provincia' => $prov,
            'Domicilio' => $domicilio,
            'estado' => '1'
        );
        $res=$this->mcliente->minsertcliente($data);
        if($res){
            $this->session->set_flashdata('correcto', 'Se guardo Correctamente');
            redirect(base_url().'mantenimiento/ccliente');
        }else{
            $this->session->set_flashdata('error', 'No se Guardo registro');
            redirect(base_url().'mantenimiento/ccliente/cadd');
        }


}


public function cedit($id){
    $data = array(
        'clienteedit' => $this->mcliente->midupdatecliente($id),
    );

    $this->load->view('layouts/header');
    $this->load->view('layouts/aside');
    $this->load->view('admin/cliente/vedit', $data);
    $this->load->view('layouts/footer');
}

public function cupdate(){

     $idcliente = $this->input->post('txtidcliente');
     $nombre = $this->input->post('txtnombre');
     $cuit = $this->input->post('txtcuit');
     $prov = $this->input->post('txtprovincia');
     $domicilio = $this->input->post('txtdomicilio');


     $data = array(

         'Nombre' => $nombre,
         'DniCuit' => $cuit,
         'Provincia' => $prov,
         'Domicilio' => $domicilio
     );

        $res = $this->mcliente->mupdatecliente($idcliente, $data);
        if($res){
            $this->session->set_flashdata('correcto', 'Se Guardo Correctamente');
            redirect(base_url().'mantenimiento/ccliente');
        }else {
            $this->session->set_flashdata('error', 'No se pudo actualizar la cliente');
            redirect(base_url().'mantenimiento/ccliente/cedit'.$idcliente);
        }


}

public function cdelete($id){

    $data=array(
        'estado' => '10'
    );
    $this->mcliente->mupdatecliente($id, $data);
    redirect(base_url().'mantenimiento/ccliente');
}


}
?>
