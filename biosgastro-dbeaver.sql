-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: biosgastro
-- ------------------------------------------------------
-- Server version	8.0.28

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `IdCliente` int NOT NULL AUTO_INCREMENT,
  `DniCuit` bigint NOT NULL,
  `Nombre` varchar(50) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `Domicilio` varchar(256) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `Localidad` varchar(256) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `Provincia` varchar(256) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `Telefono1` bigint DEFAULT NULL,
  `Telefono2` bigint DEFAULT NULL,
  PRIMARY KEY (`IdCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `material`
--

DROP TABLE IF EXISTS `material`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `material` (
  `Cantidad` char(30) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `Descripcion` char(250) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `IdMat` int NOT NULL,
  `IdOrden` int NOT NULL,
  PRIMARY KEY (`IdMat`,`IdOrden`),
  KEY `IdOrden` (`IdOrden`),
  CONSTRAINT `material_ibfk_1` FOREIGN KEY (`IdOrden`) REFERENCES `orden` (`IdOrden`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `material`
--

LOCK TABLES `material` WRITE;
/*!40000 ALTER TABLE `material` DISABLE KEYS */;
/*!40000 ALTER TABLE `material` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orden`
--

DROP TABLE IF EXISTS `orden`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orden` (
  `FechaRecepcion` datetime DEFAULT NULL,
  `IdOrden` int NOT NULL AUTO_INCREMENT,
  `TareaDesarrollar` varchar(256) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `Precio` float DEFAULT NULL,
  `IdCliente` int NOT NULL,
  `Completada` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`IdOrden`),
  KEY `IdCliente` (`IdCliente`),
  CONSTRAINT `orden_ibfk_1` FOREIGN KEY (`IdCliente`) REFERENCES `cliente` (`IdCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orden`
--

LOCK TABLES `orden` WRITE;
/*!40000 ALTER TABLE `orden` DISABLE KEYS */;
/*!40000 ALTER TABLE `orden` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `parteorden`
--

DROP TABLE IF EXISTS `parteorden`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `parteorden` (
  `IdParte` bigint NOT NULL AUTO_INCREMENT,
  `TareaDesarrollada` varchar(256) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `IdOrden` int NOT NULL,
  `Completa` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`IdParte`),
  KEY `IdOrden` (`IdOrden`),
  CONSTRAINT `parteorden_ibfk_1` FOREIGN KEY (`IdOrden`) REFERENCES `orden` (`IdOrden`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `parteorden`
--

LOCK TABLES `parteorden` WRITE;
/*!40000 ALTER TABLE `parteorden` DISABLE KEYS */;
/*!40000 ALTER TABLE `parteorden` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tecnico`
--

DROP TABLE IF EXISTS `tecnico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tecnico` (
  `Dni` int NOT NULL,
  `Nombre` varchar(50) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `Telefono` bigint DEFAULT NULL,
  `Activo` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Dni`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tecnico`
--

LOCK TABLES `tecnico` WRITE;
/*!40000 ALTER TABLE `tecnico` DISABLE KEYS */;
/*!40000 ALTER TABLE `tecnico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tecnicoorden`
--

DROP TABLE IF EXISTS `tecnicoorden`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tecnicoorden` (
  `Dni` int NOT NULL,
  `IdParte` bigint NOT NULL,
  `FechaInicio` datetime DEFAULT NULL,
  `FechaFin` datetime DEFAULT NULL,
  PRIMARY KEY (`Dni`,`IdParte`),
  KEY `IdParte` (`IdParte`),
  CONSTRAINT `tecnicoorden_ibfk_1` FOREIGN KEY (`Dni`) REFERENCES `tecnico` (`Dni`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `tecnicoorden_ibfk_2` FOREIGN KEY (`IdParte`) REFERENCES `parteorden` (`IdParte`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tecnicoorden`
--

LOCK TABLES `tecnicoorden` WRITE;
/*!40000 ALTER TABLE `tecnicoorden` DISABLE KEYS */;
/*!40000 ALTER TABLE `tecnicoorden` ENABLE KEYS */;
UNLOCK TABLES;







--
-- Dumping routines for database 'biosgastro'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-02-06 11:59:59
