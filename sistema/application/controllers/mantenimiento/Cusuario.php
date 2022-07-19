<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class Cusuario extends CI_Controller {
    function __construct(){
    parent:: __construct();
    if(!$this->session->userdata('login')){
        redirect(base_url());
    }
    $this->load->model('musuario');
    $this->load->model('mcombo');
    }


public function index(){
    $data = array (
        'usuarioindex' => $this->musuario->mselectusuario(),
    );
    $this->load->view('layouts/header');
    $this->load->view('layouts/aside');
    $this->load->view('admin/usuario/vlist', $data);
    $this->load->view('layouts/footer');
}


public function cadd(){
    $data = array (
        'tipoDocumentocombo' => $this->mcombo->mcombotabla('usuario'),
        
    );
    $this->load->view('layouts/header');
    $this->load->view('layouts/aside');
    $this->load->view('admin/usuario/vadd', $data);
    $this->load->view('layouts/footer');
}


public function cinsert(){
     
    $nombre = $this->input->post('txtnombre');
     $apellido = $this->input->post('txtapellido');
     $usuario = $this->input->post('txtusuario');
     $contraseña = $this->input->post('txtContraseña');
   

    //REGLA DE VALIDACION 
   
    
        $data = array(
            
            'nombre' => $nombre,
            'apellido' => $apellido,
            'usuario' => $usuario,
            'pass' => $contraseña,
            'estado' => '1'
        );
        $res=$this->musuario->minsertusuario($data);
        if($res){
            $this->session->set_flashdata('correcto', 'Se guardo Correctamente');
            redirect(base_url().'mantenimiento/cusuario');
        }else{
            $this->session->set_flashdata('error', 'No se Guardo registro');
            redirect(base_url().'mantenimiento/cusuario/cadd');
        }
    
    
}


public function cedit($id){
    $data = array(
        'usuarioedit' => $this->musuario->midupdateusuario($id),
    );
  
    $this->load->view('layouts/header');
    $this->load->view('layouts/aside');
    $this->load->view('admin/usuario/vedit', $data);
    $this->load->view('layouts/footer');
}

public function cupdate(){

    $idusuario = $this->input->post('txtidusuario');
    $nombre = $this->input->post('txtnombre');
     $apellido = $this->input->post('txtapellido');
     $usuario = $this->input->post('txtusuario');
     $contraseña = $this->input->post('txtContraseña');
   
    
   
        $data = array(
            'nombre' => $nombre,
            'apellido' => $apellido,
            'usuario' => $usuario,
            'pass' => $contraseña
        );

        $res = $this->musuario->mupdateusuario($idusuario, $data);
        if($res){
            $this->session->set_flashdata('correcto', 'Se Guardo Correctamente');
            redirect(base_url().'mantenimiento/cusuario');
        }else {
            $this->session->set_flashdata('error', 'No se pudo actualizar la usuario');
            redirect(base_url().'mantenimiento/cusuario/cedit'.$idusuario);
        }
   
    
}

public function cdelete($id){

    $data=array(
        'estado' => '10'
    );
    $this->musuario->mupdateusuario($id, $data);
    redirect(base_url().'mantenimiento/cusuario');
}


}
