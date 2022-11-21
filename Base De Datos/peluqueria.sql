-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 01-12-2021 a las 03:57:24
-- Versión del servidor: 10.4.21-MariaDB
-- Versión de PHP: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `peluqueria`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `dni` varchar(10) NOT NULL COMMENT 'DNI',
  `ape` varchar(50) NOT NULL COMMENT 'apellido',
  `nom` varchar(50) NOT NULL COMMENT 'nombre',
  `dom` varchar(50) NOT NULL COMMENT 'domicilio',
  `cp` varchar(10) NOT NULL COMMENT 'codigo postal',
  `sexo` varchar(10) NOT NULL,
  `fechaN` date NOT NULL COMMENT 'fecha de nacimiento',
  `tel` varchar(12) NOT NULL COMMENT 'telefono',
  `mail` varchar(50) NOT NULL COMMENT 'correo electronico'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`dni`, `ape`, `nom`, `dom`, `cp`, `sexo`, `fechaN`, `tel`, `mail`) VALUES
('1', 'Alan', 'Ferrada', 'asdasd', '7000', 'Masculino', '2021-11-30', '23122', 'alan.ferradagg@gmail.com');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cortes`
--

CREATE TABLE `cortes` (
  `id` int(11) NOT NULL COMMENT 'id corte',
  `idP` varchar(50) NOT NULL COMMENT 'id Peluquero',
  `tipoC` varchar(50) NOT NULL COMMENT 'tipo de corte',
  `dniC` varchar(10) NOT NULL COMMENT 'dni cliente',
  `fecha` date NOT NULL COMMENT 'Fecha del corte'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `cortes`
--

INSERT INTO `cortes` (`id`, `idP`, `tipoC`, `dniC`, `fecha`) VALUES
(10, '1', 'MOHICANO', '1', '2021-11-30');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `peluqueros`
--

CREATE TABLE `peluqueros` (
  `id` varchar(8) NOT NULL,
  `dni` varchar(12) NOT NULL COMMENT 'dni',
  `ape` varchar(50) NOT NULL COMMENT 'apellido',
  `nom` varchar(50) NOT NULL COMMENT 'nombre',
  `dom` varchar(50) NOT NULL COMMENT 'domicilio',
  `cp` varchar(50) NOT NULL COMMENT 'codigo postal',
  `sexo` varchar(10) NOT NULL,
  `fechaN` date NOT NULL COMMENT 'fecha nacimiento',
  `tel` varchar(12) NOT NULL COMMENT 'telefono',
  `mail` varchar(50) NOT NULL COMMENT 'correo electronico'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `peluqueros`
--

INSERT INTO `peluqueros` (`id`, `dni`, `ape`, `nom`, `dom`, `cp`, `sexo`, `fechaN`, `tel`, `mail`) VALUES
('1', '44656454', 'Mamani', 'Alejandro', 'brown 1500', '8000', 'masculino', '2002-04-27', '291545756', 'alejandromamani@gmail.com'),
('2', '44324563', 'Gomez', 'Fran', 'esmeralda 2300', '8000', 'masculino', '2002-04-25', '29145465475', 'frangomez@gmail.com'),
('3', '44556542', 'Encinas', 'Martin', 'Newton 2324', '8000', 'Masculino', '2002-09-18', '291546457', 'MartinEncinas@gmail.com');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipocorte`
--

CREATE TABLE `tipocorte` (
  `idCorte` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `descripcion` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tipocorte`
--

INSERT INTO `tipocorte` (`idCorte`, `nombre`, `descripcion`) VALUES
(1, 'Buzz', 'Consiste en un cabello muy corto, normalmente cortado al 1 y que se pasa por toda la cabeza por igua'),
(2, 'Fade', 'Significa ‘degradado’ y consiste en un corte con nuca, patillas y laterales muy cortos o incluso afeitados, volviéndose más largo en la parte superior de la cabeza, que se corta a una altura del número 4.'),
(4, 'MOHICANO', 'Efectivamente, se trata del corte típico de la tribu americana que has visto en películas de cine. Consiste en rapar ambos lados de la cabeza, dejándose una cresta en la zona central que va desde la frente hasta la nuca.'),
(6, 'Mullet', 'El corte consiste en llevar al número 4 la parte superior y los lados de la cabeza y dejar la parte baja trasera más larga, hasta llegar a los hombros o incluso más.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipousuarios`
--

CREATE TABLE `tipousuarios` (
  `idTipo` int(11) NOT NULL,
  `Nombre` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tipousuarios`
--

INSERT INTO `tipousuarios` (`idTipo`, `Nombre`) VALUES
(2, 'Administrador'),
(3, 'Usuario');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `idUser` int(11) NOT NULL,
  `User` varchar(45) NOT NULL,
  `Password` varchar(80) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `idTipoUser` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`idUser`, `User`, `Password`, `Nombre`, `idTipoUser`) VALUES
(7, 'Fran', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220', 'Alan', 2),
(8, 'alansito', '40bd001563085fc35165329ea1ff5c5ecbdbbeef', 'Alan', 2);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD KEY `dni` (`dni`);

--
-- Indices de la tabla `cortes`
--
ALTER TABLE `cortes`
  ADD PRIMARY KEY (`id`),
  ADD KEY `dniC` (`dniC`),
  ADD KEY `idP` (`idP`),
  ADD KEY `tipoC` (`tipoC`);

--
-- Indices de la tabla `peluqueros`
--
ALTER TABLE `peluqueros`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `tipocorte`
--
ALTER TABLE `tipocorte`
  ADD PRIMARY KEY (`idCorte`);

--
-- Indices de la tabla `tipousuarios`
--
ALTER TABLE `tipousuarios`
  ADD PRIMARY KEY (`idTipo`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`idUser`),
  ADD KEY `idTipoUser` (`idTipoUser`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cortes`
--
ALTER TABLE `cortes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'id corte', AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de la tabla `tipocorte`
--
ALTER TABLE `tipocorte`
  MODIFY `idCorte` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `tipousuarios`
--
ALTER TABLE `tipousuarios`
  MODIFY `idTipo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `idUser` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `cortes`
--
ALTER TABLE `cortes`
  ADD CONSTRAINT `cortes_ibfk_1` FOREIGN KEY (`dniC`) REFERENCES `clientes` (`dni`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cortes_ibfk_2` FOREIGN KEY (`idP`) REFERENCES `peluqueros` (`id`);

--
-- Filtros para la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `usuarios_ibfk_1` FOREIGN KEY (`idTipoUser`) REFERENCES `tipousuarios` (`idTipo`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
