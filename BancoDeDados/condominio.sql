-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 23-Nov-2019 às 21:47
-- Versão do servidor: 10.4.8-MariaDB
-- versão do PHP: 7.1.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `condominio`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `apartamento`
--

CREATE TABLE `apartamento` (
  `IdApartamento` int(11) NOT NULL,
  `Apt` int(11) NOT NULL,
  `Bloco` varchar(5) NOT NULL,
  `Vaga` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `apartamento`
--

INSERT INTO `apartamento` (`IdApartamento`, `Apt`, `Bloco`, `Vaga`) VALUES
(1, 101, 'A', '11'),
(2, 102, 'A', '12'),
(3, 103, 'A', '13'),
(4, 104, 'A', '14'),
(5, 105, 'A', '15'),
(6, 106, 'A', '16'),
(7, 107, 'A', '17'),
(8, 108, 'A', '18'),
(9, 201, 'A', '19'),
(10, 202, 'A', '20'),
(11, 203, 'A', '21'),
(12, 204, 'A', '22'),
(13, 205, 'A', '23'),
(14, 206, 'A', '24'),
(15, 207, 'A', '25'),
(16, 208, 'A', '26'),
(17, 101, 'B', '27'),
(18, 102, 'B', '28'),
(19, 103, 'B', '29'),
(20, 104, 'B', '30'),
(21, 105, 'B', '31'),
(22, 106, 'B', '32'),
(23, 107, 'B', '33'),
(24, 108, 'B', '34'),
(25, 201, 'B', '35'),
(26, 202, 'B', '36'),
(27, 203, 'B', '37'),
(28, 204, 'B', '38'),
(29, 205, 'B', '39'),
(30, 206, 'B', '40'),
(31, 207, 'B', '41'),
(32, 208, 'B', '42');

-- --------------------------------------------------------

--
-- Estrutura da tabela `comunicado`
--

CREATE TABLE `comunicado` (
  `IdComunicado` int(11) NOT NULL,
  `Titulo` varchar(100) NOT NULL,
  `DataComunicado` date NOT NULL,
  `Descricao` text NOT NULL,
  `IdSindicoFkComunicado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `comunicado`
--

INSERT INTO `comunicado` (`IdComunicado`, `Titulo`, `DataComunicado`, `Descricao`, `IdSindicoFkComunicado`) VALUES
(1, '', '2019-11-23', 'No alto daquele cume\r\nPlantei uma roseira\r\nO vento no cume bate\r\nA rosa no cume cheira\r\nQuando vem a chuva fina\r\nSalpicos no cume caem\r\nFormigas no cume entram\r\nAbelhas do cume me saem\r\nQuando cai a chuva grossa\r\nA água do cume desce\r\nO barro do cume escorre\r\nO mato no cume cresce\r\nEntão quando cessa a chuva\r\nNo cume volta a alegria\r\nPois torna a brilhar de novo\r\nO sol que no cume ardia\r\nNo alto daquele cume\r\nPlantei uma roseira\r\nO vento no cume bate\r\nA rosa no cume cheira\r\nQuando vem a chuva fina\r\n(No seu aro, aro)\r\nSalpicos no cume caem\r\n(No seu aro, aro)\r\nFormigas no cume entram\r\n(No seu aro, aro)\r\nAbelhas do cume me saem\r\n(No meu aro, aro)\r\nQuando cai a chuva grossa\r\nA água do cume desce\r\nO barro do cume escorre\r\nO mato no cume cresce\r\nEntão quando cessa a chuva\r\nNo cume volta a alegria\r\nPois torna a brilhar de novo\r\nO sol que no cume ardia\r\nPois torna a brilhar de novo\r\nO sol que no cume ardia\r\nPois torna a brilhar de novo\r\nO sol que no cume...', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `correspondencia`
--

CREATE TABLE `correspondencia` (
  `IdCorrespondencia` int(11) NOT NULL,
  `IdMoradorFkCorresp` int(11) NOT NULL,
  `IdSindicoFkOcorrencia` int(11) NOT NULL,
  `IdApartamentoFkCorresp` int(11) NOT NULL,
  `Status` tinyint(1) NOT NULL,
  `DataRecebimento` date NOT NULL,
  `Obs` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `local`
--

CREATE TABLE `local` (
  `IdLocal` int(11) NOT NULL,
  `NomeLocal` varchar(30) NOT NULL,
  `Valor` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `local`
--

INSERT INTO `local` (`IdLocal`, `NomeLocal`, `Valor`) VALUES
(1, 'Churrasqueira 1', 'R$ 55,00'),
(2, 'Churrasqueira 2', 'R$ 55,00'),
(3, 'Churrasqueira 3', 'R$ 55,00'),
(4, 'Salão de Festas Bloco A', 'R$ 80,00'),
(5, 'Salão de Festas Bloco B', 'R$ 80,00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `morador`
--

CREATE TABLE `morador` (
  `IdMorador` int(11) NOT NULL,
  `Nome` varchar(55) NOT NULL,
  `Email` varchar(55) NOT NULL,
  `Cpf` varchar(30) NOT NULL,
  `Telefone` varchar(30) NOT NULL,
  `IdApartamentoFkMorador` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `morador`
--

INSERT INTO `morador` (`IdMorador`, `Nome`, `Email`, `Cpf`, `Telefone`, `IdApartamentoFkMorador`) VALUES
(1, 'Paulo Vinícius Gomes de Queirós', 'pauloks.2000@gmail.com', '07450879140', '61981679773', 16),
(2, 'Testeteste', 'Teste@gmail.com', '123123123', '12312312312', 16);

-- --------------------------------------------------------

--
-- Estrutura da tabela `reserva`
--

CREATE TABLE `reserva` (
  `IdReserva` int(11) NOT NULL,
  `IdMoradorFkReserva` int(11) NOT NULL,
  `IdLocalFkReserva` int(11) NOT NULL,
  `DataSolicitacao` date NOT NULL,
  `DataReserva` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `reserva`
--

INSERT INTO `reserva` (`IdReserva`, `IdMoradorFkReserva`, `IdLocalFkReserva`, `DataSolicitacao`, `DataReserva`) VALUES
(1, 1, 3, '2019-11-23', '2019-11-30');

-- --------------------------------------------------------

--
-- Estrutura da tabela `sindico`
--

CREATE TABLE `sindico` (
  `IdSindico` int(11) NOT NULL,
  `Nome` varchar(55) NOT NULL,
  `Email` varchar(30) NOT NULL,
  `Cpf` varchar(20) NOT NULL,
  `Telefone` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `sindico`
--

INSERT INTO `sindico` (`IdSindico`, `Nome`, `Email`, `Cpf`, `Telefone`) VALUES
(1, 'Ronaldo da Silva Pereira', 'ronaldosp@gmail.com', '03451946130', '061984896238');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `apartamento`
--
ALTER TABLE `apartamento`
  ADD PRIMARY KEY (`IdApartamento`);

--
-- Índices para tabela `comunicado`
--
ALTER TABLE `comunicado`
  ADD PRIMARY KEY (`IdComunicado`),
  ADD KEY `IdSindicoFkComunicado` (`IdSindicoFkComunicado`);

--
-- Índices para tabela `correspondencia`
--
ALTER TABLE `correspondencia`
  ADD PRIMARY KEY (`IdCorrespondencia`),
  ADD KEY `IdApartamentoFkCorresp` (`IdApartamentoFkCorresp`),
  ADD KEY `IdMoradorFkCorresp` (`IdMoradorFkCorresp`),
  ADD KEY `correspondencia_ibfk_3` (`IdSindicoFkOcorrencia`);

--
-- Índices para tabela `local`
--
ALTER TABLE `local`
  ADD PRIMARY KEY (`IdLocal`);

--
-- Índices para tabela `morador`
--
ALTER TABLE `morador`
  ADD PRIMARY KEY (`IdMorador`),
  ADD KEY `IdApartamentoFkMorador` (`IdApartamentoFkMorador`);

--
-- Índices para tabela `reserva`
--
ALTER TABLE `reserva`
  ADD PRIMARY KEY (`IdReserva`),
  ADD KEY `IdLocalFkReserva` (`IdLocalFkReserva`),
  ADD KEY `IdMoradorFkReserva` (`IdMoradorFkReserva`);

--
-- Índices para tabela `sindico`
--
ALTER TABLE `sindico`
  ADD PRIMARY KEY (`IdSindico`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `apartamento`
--
ALTER TABLE `apartamento`
  MODIFY `IdApartamento` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT de tabela `comunicado`
--
ALTER TABLE `comunicado`
  MODIFY `IdComunicado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `correspondencia`
--
ALTER TABLE `correspondencia`
  MODIFY `IdCorrespondencia` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `local`
--
ALTER TABLE `local`
  MODIFY `IdLocal` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `morador`
--
ALTER TABLE `morador`
  MODIFY `IdMorador` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `reserva`
--
ALTER TABLE `reserva`
  MODIFY `IdReserva` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `sindico`
--
ALTER TABLE `sindico`
  MODIFY `IdSindico` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `comunicado`
--
ALTER TABLE `comunicado`
  ADD CONSTRAINT `comunicado_ibfk_1` FOREIGN KEY (`IdSindicoFkComunicado`) REFERENCES `sindico` (`IdSindico`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `correspondencia`
--
ALTER TABLE `correspondencia`
  ADD CONSTRAINT `correspondencia_ibfk_1` FOREIGN KEY (`IdApartamentoFkCorresp`) REFERENCES `apartamento` (`IdApartamento`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `correspondencia_ibfk_2` FOREIGN KEY (`IdMoradorFkCorresp`) REFERENCES `morador` (`IdMorador`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `correspondencia_ibfk_3` FOREIGN KEY (`IdSindicoFkOcorrencia`) REFERENCES `sindico` (`IdSindico`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `morador`
--
ALTER TABLE `morador`
  ADD CONSTRAINT `morador_ibfk_1` FOREIGN KEY (`IdApartamentoFkMorador`) REFERENCES `apartamento` (`IdApartamento`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `reserva`
--
ALTER TABLE `reserva`
  ADD CONSTRAINT `reserva_ibfk_1` FOREIGN KEY (`IdLocalFkReserva`) REFERENCES `local` (`IdLocal`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `reserva_ibfk_2` FOREIGN KEY (`IdMoradorFkReserva`) REFERENCES `morador` (`IdMorador`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
