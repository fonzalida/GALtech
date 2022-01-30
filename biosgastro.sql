-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 26-01-2022 a las 02:43:15
-- Versión del servidor: 10.4.21-MariaDB
-- Versión de PHP: 8.0.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `biosgastro`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (

  `IdCliente` int(11) NOT NULL,
  `DniCuit` int(20) NOT NULL,
  `Nombre` varchar(50) COLLATE utf8_spanish_ci DEFAULT NULL,
  `Domicilio` varchar(256) COLLATE utf8_spanish_ci DEFAULT NULL,
  `Localidad` varchar(256) COLLATE utf8_spanish_ci DEFAULT NULL,
  `Provincia` varchar(256) COLLATE utf8_spanish_ci DEFAULT NULL,
  `Telefono1` int(20) DEFAULT NULL,
  `Telefono2` int(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
--
-- Estructura de tabla para la tabla `material`
--

CREATE TABLE `material` (
  `Cantidad` char(30) COLLATE utf8_spanish_ci NOT NULL,
  `Descripcion` char(250) COLLATE utf8_spanish_ci NOT NULL,
  `IdMat` int(11) NOT NULL,
  `IdOrden` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `orden`
--

CREATE TABLE `orden` (
  `FechaRecepcion` datetime DEFAULT NULL,
  `IdOrden` int(11) NOT NULL,
  `TareaDesarrollar` varchar(256) COLLATE utf8_spanish_ci DEFAULT NULL,
  `TareaDesarrollada` varchar(256) COLLATE utf8_spanish_ci DEFAULT NULL,
  `Precio` float DEFAULT NULL,
  `IdCliente` int(20) NOT NULL,
  `Completada` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `parteorden`
--

CREATE TABLE `parteorden` (
  `IdParte` int(11) NOT NULL,
  `FechaInicio` datetime NOT NULL,
  `FechaFin` datetime NOT NULL,
  `IdOrden` int(11) NOT NULL,
  `Completa` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `persona`
--

-- CREATE TABLE `persona` (
--   `Dni` int(11) NOT NULL,
--   `Nombre` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
--   `Apellido` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
--   `Telefono` int(20) COLLATE utf8_spanish_ci DEFAULT NULL

-- ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tecnico`
--

CREATE TABLE `tecnico` (
  `Dni` int(11) NOT NULL,
  `Nombre` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `Telefono` int(20) COLLATE utf8_spanish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tecnicoorden`
--

CREATE TABLE `tecnicoorden` (
  `Dni` int(11) NOT NULL,
  `IdParte` int(11) NOT NULL,
  `IdOrden` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `titular`
--

-- CREATE TABLE `titular` (
--   `Dni` int(11) NOT NULL,
--   `IdCliente` int(11) NOT NULL
-- ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--


--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`IdCliente`);

--
-- Indices de la tabla `material`
--
ALTER TABLE `material`
  ADD PRIMARY KEY (`IdMat`,`IdOrden`),
  ADD KEY `IdOrden` (`IdOrden`);

--
-- Indices de la tabla `orden`
--
ALTER TABLE `orden`
  ADD PRIMARY KEY (`IdOrden`),
  ADD KEY `IdCliente` (`IdCliente`);

--
-- Indices de la tabla `parteorden`
--
ALTER TABLE `parteorden`
  ADD PRIMARY KEY (`IdParte`,`IdOrden`),
  ADD KEY `IdOrden` (`IdOrden`);

--
-- Indices de la tabla `persona`
--
-- ALTER TABLE `persona`
--   ADD PRIMARY KEY (`Dni`);

--
-- Indices de la tabla `tecnico`
--
ALTER TABLE `tecnico`
  ADD PRIMARY KEY (`Dni`);

--
-- Indices de la tabla `tecnicoorden`
--
ALTER TABLE `tecnicoorden`
  ADD PRIMARY KEY (`Dni`,`IdParte`,`IdOrden`),
  ADD KEY `IdParte` (`IdParte`,`IdOrden`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `IdCliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;

--
-- AUTO_INCREMENT de la tabla `orden`
--
ALTER TABLE `orden`
  MODIFY `IdOrden` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `material`
--
ALTER TABLE `material`
  ADD CONSTRAINT `material_ibfk_1` FOREIGN KEY (`IdOrden`) REFERENCES `orden` (`IdOrden`);

--
-- Filtros para la tabla `orden`
--
ALTER TABLE `orden`
  ADD CONSTRAINT `orden_ibfk_1` FOREIGN KEY (`IdCliente`) REFERENCES `cliente` (`IdCliente`);

--
-- Filtros para la tabla `parteorden`
--
ALTER TABLE `parteorden`
  ADD CONSTRAINT `parteorden_ibfk_1` FOREIGN KEY (`IdOrden`) REFERENCES `orden` (`IdOrden`);

--
--
-- Filtros para la tabla `tecnicoorden`
--
ALTER TABLE `tecnicoorden`
  ADD CONSTRAINT `tecnicoorden_ibfk_1` FOREIGN KEY (`Dni`) REFERENCES `tecnico` (`Dni`),
  ADD CONSTRAINT `tecnicoorden_ibfk_2` FOREIGN KEY (`IdParte`,`IdOrden`) REFERENCES `parteorden` (`IdParte`, `IdOrden`);

--

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
