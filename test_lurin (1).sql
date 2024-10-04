-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 04-10-2024 a las 04:13:36
-- Versión del servidor: 10.4.28-MariaDB
-- Versión de PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `test_lurin`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` text NOT NULL,
  `email` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `email`) VALUES
(1, 'admin', '$2y$10$0HBlAMNnyIKp7EP5gs.8Du3ZW69RXqB6p.5iy2BrLJwhEersUmPUW', 'admin@admin.com'),
(2, 'eduar', '$2a$10$29PeDrfhgveKHEo0yDKg9urJUZeLjr8p8nKeE1taGakXiSUlOMKF6', 'correo'),
(7, 'juancito', '$2a$10$HJa5sqf7dSioLgqMx5DKXuSzMTwrs1I321WwRsxXCJN/.xhCzb5KG', 'juan@juan'),
(8, 'dcfdsfew', 'sdfes', 'saferfs'),
(9, 'alberto', '$2a$10$wyPvum3jmZDXJ8BpwFWDR.asaWtM7XGfPF3YRLZQM0ukQB7QNF9Dy', 'alberto@alberto.com'),
(10, 'juancito', 'juan', 'juan@juancito.com'),
(11, 'vendedor', 'vendedor', 'vendedor'),
(12, 'armando', '$2a$10$gck6ywbSgbyUjvtCdIkflO.3HLYPsYsUrnrwb7lfMdGUWZ9cojnCG', 'armando@armando'),
(13, 'apaza', '$2a$10$chZKb8TilL610btOtSMuuOqLR/CMHc4RtZc2zr/72ted/Ls4jMzBK', 'correo');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
