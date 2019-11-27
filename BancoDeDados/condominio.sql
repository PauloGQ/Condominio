-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 27-Nov-2019 às 22:55
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
(2, 'Cigarro em condomínio', '2019-11-20', 'Caros moradores,\r\n \r\nJá parou para pensar que o cheiro pode incomodar tanto quanto um barulho? E que talvez, o cheiro do seu cigarro incomode muito seus vizinhos?\r\n \r\nA ideia não é impedi-lo de fumar em sua unidade! Porém, fica aqui o convite para a reflexão: você gostaria de sentir cheiro de churrasco todos os dias, de manhã, de tarde e de noite? De segunda a segunda? Ou aquele cheiro de perfume doce? Ou de produto de limpeza?\r\nImaginamos que não. \r\n \r\nTambém pedimos aos senhores moradores que, ao fumarem nas áreas comuns abertas (como piscina, locais descobertos, etc.), que não joguem as bitucas no chão. O local correto de destinação é o lixo.\r\n \r\nAinda falando sobre esse assunto, é de fundamental importância que não se jogue lixo pela janela. Bitucas acesas podem entrar em uma unidade e iniciar um incêndio, queimar uma pessoa ou um animal de estimação. As apagadas vão se acumulando no chão dando um aspecto de sujeira e falta de higiene ao condomínio. \r\n \r\nContamos com a sua ajuda e colaboração, sempre, para que o nosso condomínio seja um local cada vez melhor para se morar.\r\n \r\nAtenciosamente,', 1),
(4, 'PROIBIÇÃO DE ANIMAIS NO CONDOMÍNIO ', '2019-11-26', 'é nula e sem efeito qualquer CONVENÇÃO CONDOMINIAL que proíba a existência, ou permanência, de animais doméstico, especialmente de cães e gatos, em condomínio, vez que tal proibição afronta a Lei Maior do País, que é a Constituição Federal, onde estão tutelados juridicamente a vida e o bem estar desses seres.\r\nAssim, desde que o animal não causa risco à saúde ou a segurança dos demais moradores e não tire o sossego da vizinhança, sua permanência é permitida, sendo nula qualquer convenção do condomínio que proíba a permanência de animais domésticos, por ser inconstitucional.\r\nEntretanto, as convenções podem restringir a forma como os animais são mantidos nas áreas de uso comum, como, por exemplo, estabelecer que devem usar o elevador de serviço, que devem circular nas áreas comuns com guia, etc.\r\nFriso que o animal não pode colocar em risco a saúde e a segurança dos demais moradores e também não pode tirar o sossego destes moradores. Então, o cão não pode ficar latindo a noite inteira, por exemplo. Se for um animal bravo, deve circular com focinheira nas áreas comuns. E, é claro, quando for circular com seu animal nas áreas comuns, sempre levar um saquinho para recolher o cocô.\r\nPortanto, qualquer que seja o argumento da convenção de seu condomínio, você pode e deve levar seu animal com você e, se for o caso, procure um advogado.', 3),
(5, 'Benefícios da Coleta Seletiva em Condomínios', '2019-11-27', '• A Reciclagem de lixo é exatamente como a vida em condomínio. Se cada um fizer a sua parte, não fica pesado para ninguém e todos saem ganhando!\r\n• Reciclando seu lixo, você colabora não apenas com o meio ambiente. Há indústrias inteiras voltadas para a reciclagem. O reaproveitamento de embalagens gera empregos e dinheiro para muita gente\r\n• Para facilitar o início do hábito, comece separando apenas o lixo reciclável do orgânico\r\n• Use os sacos certos para lixo orgânico e para os reaproveitáveis\r\n• Peça para os seus filhos ajudarem, eles com certeza ficarão felizes em ser parte do processo\r\n• Limpe embalagens com resto de comida e também as deixe seca\r\n• Crie um espaço na cozinha para deixar o material reciclável já limpo\r\n• Converse com a sua empregada doméstica sobre a importância de separar o lixo orgânico do reciclável\r\n• Para ajudar, dê o exemplo separando embalagens para a reciclagem. Monitorar a limpeza do que está sendo separado também ajuda!\r\n• Com a ajuda da sua família, o nosso condomínio se torna mais cidadão\r\nObrigado por participar!', 3);

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
(4, 'Gabriel José Resende Cesarini', 'gabriel@gmail.com', '4848484848', '6135326803', 1),
(5, 'Guilherme Lima', 'guilherme@gmail.com', '4848484848', '6135326803', 12),
(7, 'Paulo Vinícius Gomes de Queirós', 'Pauloks.2000@gmail.com', '07450879140', '061981679973', 5);

-- --------------------------------------------------------

--
-- Estrutura da tabela `ocorrencia`
--

CREATE TABLE `ocorrencia` (
  `IdOcorrencia` int(11) NOT NULL,
  `IdMoradorFkOcorrencia` int(11) NOT NULL,
  `IdSindicoFkOcorrencia` int(11) NOT NULL,
  `Tipo` varchar(30) NOT NULL,
  `DataOcorrencia` varchar(20) NOT NULL,
  `Descricao` varchar(1000) NOT NULL,
  `Status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `ocorrencia`
--

INSERT INTO `ocorrencia` (`IdOcorrencia`, `IdMoradorFkOcorrencia`, `IdSindicoFkOcorrencia`, `Tipo`, `DataOcorrencia`, `Descricao`, `Status`) VALUES
(1, 7, 1, 'Reclamação', '27/11/2019', 'Na presente data, O morador do apartamento 201A estacionou o carro erroneamente na minha vaga, quero que seja resolvido o mais rápido possível!', 'Respondida'),
(3, 5, 1, 'Reclamação', '25/05/2019', '', 'em analise');

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
(2, 4, 4, '2019-11-23', '2019-11-25'),
(7, 7, 1, '2000-10-16', '2019-11-24');

-- --------------------------------------------------------

--
-- Estrutura da tabela `sindico`
--

CREATE TABLE `sindico` (
  `IdSindico` int(11) NOT NULL,
  `NomeSindico` varchar(55) NOT NULL,
  `Email` varchar(30) NOT NULL,
  `Cpf` varchar(20) NOT NULL,
  `Telefone` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `sindico`
--

INSERT INTO `sindico` (`IdSindico`, `NomeSindico`, `Email`, `Cpf`, `Telefone`) VALUES
(1, 'Ronaldo Benedito', 'Ronaldosindico@gmail.com', '07450879140', '061981679773'),
(3, 'José Rafael', 'Josesindico@gmail.com', '07450879140', '061985000021');

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
-- Índices para tabela `ocorrencia`
--
ALTER TABLE `ocorrencia`
  ADD PRIMARY KEY (`IdOcorrencia`),
  ADD KEY `IdMoradorFkOcorrencia` (`IdMoradorFkOcorrencia`),
  ADD KEY `IdSindicoFkOcorrencia` (`IdSindicoFkOcorrencia`);

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
  MODIFY `IdComunicado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

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
  MODIFY `IdMorador` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `ocorrencia`
--
ALTER TABLE `ocorrencia`
  MODIFY `IdOcorrencia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `reserva`
--
ALTER TABLE `reserva`
  MODIFY `IdReserva` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT de tabela `sindico`
--
ALTER TABLE `sindico`
  MODIFY `IdSindico` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

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
-- Limitadores para a tabela `ocorrencia`
--
ALTER TABLE `ocorrencia`
  ADD CONSTRAINT `ocorrencia_ibfk_1` FOREIGN KEY (`IdMoradorFkOcorrencia`) REFERENCES `morador` (`IdMorador`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ocorrencia_ibfk_2` FOREIGN KEY (`IdSindicoFkOcorrencia`) REFERENCES `sindico` (`IdSindico`) ON DELETE CASCADE ON UPDATE CASCADE;

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
