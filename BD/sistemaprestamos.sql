-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 03-04-2019 a las 20:32:51
-- Versión del servidor: 10.1.37-MariaDB
-- Versión de PHP: 5.6.40

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `sistemaprestamos`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `id_cliente` int(5) NOT NULL,
  `nombre_cliente` varchar(50) NOT NULL,
  `telefono_cliente` varchar(13) NOT NULL,
  `celular_cliente` varchar(13) NOT NULL,
  `otro_telefono_cliente` varchar(13) NOT NULL,
  `cedula_cliente` varchar(13) NOT NULL,
  `email_cliente` varchar(40) NOT NULL,
  `direccion_cliente` varchar(50) NOT NULL,
  `estado_cliente` bit(1) NOT NULL DEFAULT b'1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`id_cliente`, `nombre_cliente`, `telefono_cliente`, `celular_cliente`, `otro_telefono_cliente`, `cedula_cliente`, `email_cliente`, `direccion_cliente`, `estado_cliente`) VALUES
(1, 'Edgar Ariel Tavarez Lopez', 'telefono', 'celuar', 'otro', 'cedula', 'email', 'direccion pekin n', b'1'),
(2, 'Juan', '', '', '', '', '', '', b'0'),
(3, 'Jose', 'telefono', 'celular', 'otro', 'cedula', 'email', 'direccion', b'1'),
(4, 'Pedro', '809-426-4123', '809-569-2352', '809-512-5223', '4-05050', 'pedro004@hotmail.com', 'Los quemados', b'1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalles_prestamos`
--

CREATE TABLE `detalles_prestamos` (
  `id_prestamo` int(5) NOT NULL,
  `numero_cuota` smallint(6) NOT NULL,
  `fecha_cuota` date NOT NULL,
  `monto_cuota` int(11) NOT NULL,
  `interes_cuota` int(11) NOT NULL,
  `abonos_cuota` int(11) NOT NULL,
  `mora_cuota` int(11) NOT NULL,
  `deuda_cuota` int(11) NOT NULL,
  `estado_cuota` char(11) NOT NULL DEFAULT 'Pendiente'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalles_prestamos`
--

INSERT INTO `detalles_prestamos` (`id_prestamo`, `numero_cuota`, `fecha_cuota`, `monto_cuota`, `interes_cuota`, `abonos_cuota`, `mora_cuota`, `deuda_cuota`, `estado_cuota`) VALUES
(1, 1, '2019-04-01', 66000, 6000, 67320, 1320, 0, 'Pagado'),
(1, 2, '2019-04-03', 66000, 6000, 66000, 0, 0, 'Pagado'),
(1, 3, '2019-04-04', 66000, 6000, 66000, 0, 0, 'Pagado'),
(1, 4, '2019-04-05', 66000, 6000, 66000, 0, 0, 'Pagado'),
(1, 5, '2019-04-06', 66000, 6000, 66000, 0, 0, 'Pagado'),
(2, 1, '2019-04-08', 6750, 500, 6750, 0, 0, 'Pagado'),
(2, 2, '2019-04-15', 6750, 500, 6750, 0, 0, 'Pagado'),
(2, 3, '2019-04-22', 6750, 500, 6750, 0, 0, 'Pagado'),
(2, 4, '2019-04-29', 6750, 500, 6750, 0, 0, 'Pagado'),
(3, 1, '2019-04-02', 540, 40, 556, 16, 0, 'Pagado'),
(3, 2, '2019-04-03', 540, 40, 540, 0, 0, 'Pagado'),
(3, 3, '2019-04-04', 540, 40, 2, 0, 538, 'Pendiente'),
(3, 4, '2019-04-05', 540, 40, 0, 0, 540, 'Pendiente'),
(4, 1, '2019-04-02', 13500, 1000, 0, 0, 13500, 'Pendiente'),
(4, 2, '2019-04-03', 13500, 1000, 0, 0, 13500, 'Pendiente'),
(4, 3, '2019-04-04', 13500, 1000, 0, 0, 13500, 'Pendiente'),
(4, 4, '2019-04-05', 13500, 1000, 0, 0, 13500, 'Pendiente'),
(5, 1, '2019-04-02', 1100, 100, 0, 0, 1100, 'Pendiente'),
(5, 2, '2019-04-03', 1100, 100, 0, 0, 1100, 'Pendiente'),
(5, 3, '2019-04-04', 1100, 100, 0, 0, 1100, 'Pendiente'),
(5, 4, '2019-04-05', 1100, 100, 0, 0, 1100, 'Pendiente'),
(5, 5, '2019-04-06', 1100, 100, 0, 0, 1100, 'Pendiente');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `fecha_mora`
--

CREATE TABLE `fecha_mora` (
  `fecha` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `fecha_mora`
--

INSERT INTO `fecha_mora` (`fecha`) VALUES
('2019-04-03');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `prestamos`
--

CREATE TABLE `prestamos` (
  `id_prestamo` int(5) NOT NULL,
  `id_cliente` int(5) NOT NULL,
  `monto_prestamo` int(11) NOT NULL,
  `interes_prestamo` tinyint(4) NOT NULL,
  `cuotas_prestamo` smallint(6) NOT NULL,
  `mora_prestamo` tinyint(4) NOT NULL,
  `plazo_prestamo` char(9) NOT NULL,
  `total_prestamo` int(11) NOT NULL,
  `total_interes_prestamo` int(11) NOT NULL,
  `monto_cuota_prestamo` int(11) NOT NULL,
  `abonos_prestamo` int(11) NOT NULL DEFAULT '0',
  `fecha_prestamo` date NOT NULL,
  `fecha_inicio_prestamo` date NOT NULL,
  `estado_prestamo` char(11) NOT NULL DEFAULT 'Pendiente'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `prestamos`
--

INSERT INTO `prestamos` (`id_prestamo`, `id_cliente`, `monto_prestamo`, `interes_prestamo`, `cuotas_prestamo`, `mora_prestamo`, `plazo_prestamo`, `total_prestamo`, `total_interes_prestamo`, `monto_cuota_prestamo`, `abonos_prestamo`, `fecha_prestamo`, `fecha_inicio_prestamo`, `estado_prestamo`) VALUES
(1, 4, 300000, 2, 5, 2, 'Diario', 331320, 30000, 66000, 331320, '2019-04-01', '2019-04-01', 'Pagado'),
(2, 1, 25000, 2, 4, 2, 'Semanal', 27000, 2000, 6750, 27000, '2019-04-01', '2019-04-01', 'Pagado'),
(3, 4, 2000, 2, 4, 3, 'Diario', 2176, 160, 540, 1098, '2019-04-01', '2019-04-01', 'Pendiente'),
(4, 1, 50000, 2, 4, 2, 'Diario', 54000, 4000, 13500, 0, '2019-04-01', '2019-04-01', 'Pendiente'),
(5, 1, 5000, 2, 9, 1, 'Diario', 5500, 500, 1100, 0, '2019-04-01', '2019-04-01', 'Pendiente');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `referentes`
--

CREATE TABLE `referentes` (
  `id_referente` int(5) NOT NULL,
  `id_cliente` int(5) NOT NULL,
  `nombre_referente` varchar(50) NOT NULL,
  `telefono_referente` varchar(13) NOT NULL,
  `celular_referente` varchar(13) NOT NULL,
  `otro_telefono_referente` varchar(13) NOT NULL,
  `cedula_referente` varchar(13) NOT NULL,
  `email_referente` varchar(40) NOT NULL,
  `direccion_referente` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `referentes`
--

INSERT INTO `referentes` (`id_referente`, `id_cliente`, `nombre_referente`, `telefono_referente`, `celular_referente`, `otro_telefono_referente`, `cedula_referente`, `email_referente`, `direccion_referente`) VALUES
(1, 1, 'joser', '2121', '21', '323', '32', '0.', 'Pekin'),
(2, 3, 'prueba 3', 'telefono', 'celuar', 'otro', 'cedula', 'email', 'direccion'),
(3, 4, 'm,n', 'm,n', 'm,n', 'm,n', 'm,n', 'm,n', 'm,n');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `id_usuario` int(1) NOT NULL,
  `nick_usuario` varchar(25) NOT NULL,
  `clave_usuario` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`id_usuario`, `nick_usuario`, `clave_usuario`) VALUES
(1, 'admin', 'admin');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`id_cliente`);

--
-- Indices de la tabla `prestamos`
--
ALTER TABLE `prestamos`
  ADD PRIMARY KEY (`id_prestamo`);

--
-- Indices de la tabla `referentes`
--
ALTER TABLE `referentes`
  ADD PRIMARY KEY (`id_referente`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id_usuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `id_cliente` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `prestamos`
--
ALTER TABLE `prestamos`
  MODIFY `id_prestamo` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `referentes`
--
ALTER TABLE `referentes`
  MODIFY `id_referente` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id_usuario` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
