CREATE TABLE "InformacoesPessoais" (
    "Id" SERIAL PRIMARY KEY,
    "NomeCompleto" VARCHAR(100),
    "Profissao" VARCHAR(100),
    "ProfissaoEn" VARCHAR(100),
    "ProfissaoEs" VARCHAR(100),
    "Email" VARCHAR(100),
    "LinkLinkedin" VARCHAR(200),
    "LinkGitHub" VARCHAR(200),
    "Telefone" VARCHAR(50),
    "Localizacao" VARCHAR(100)
);

CREATE TABLE "ExperienciasProfissionais" (
    "Id" SERIAL PRIMARY KEY,
    "Cargo" VARCHAR(100),
    "CargoEn" VARCHAR(100),
    "CargoEs" VARCHAR(100),
    "Empresa" VARCHAR(100),
    "DataInicio" DATE,
    "DataFim" DATE,
    "Descricao" TEXT,
    "DescricaoEn" TEXT, 
    "DescricaoEs" TEXT  
);

CREATE TABLE "Hardskills" (
    "Id" SERIAL PRIMARY KEY,
    "NomeHardskill" VARCHAR(100),
    "Nivel" INT
);

CREATE TABLE "Softskills" (
    "Id" SERIAL PRIMARY KEY,
    "NomeSoftskill" VARCHAR(100),
    "NomeSoftskillEn" VARCHAR(100),
    "NomeSoftskillEs" VARCHAR(100),
    "Nivel" INT
);

CREATE TABLE "Curiosidades" (
    "Id" SERIAL PRIMARY KEY,
    "Descricao" TEXT,
    "DescricaoEn" TEXT,
    "DescricaoEs" TEXT
);

-- Inserção dos Dados

INSERT INTO "InformacoesPessoais" ("NomeCompleto", "Profissao", "ProfissaoEn", "ProfissaoEs", "Email", "LinkLinkedin", "LinkGitHub", "Telefone", "Localizacao")
VALUES ('Wendell Pereira', 'Desenvolvedor Full Stack', 'Full Stack Developer', 'Desarrollador Full Stack', 'rwendell.regis@gmail.com', 'https://linkedin.com/in/ven-del', 'https://github.com/ven-del', '+55 (85) 997-017-021', 'Fortaleza, CE');

INSERT INTO "ExperienciasProfissionais" ("Cargo", "CargoEn", "CargoEs", "Empresa", "DataInicio", "DataFim", "Descricao", "DescricaoEn", "DescricaoEs")
VALUES 
('Jr Full Stack GenAI Developer', 'Jr Full Stack GenAI Developer', 'Desarrollador Jr Full Stack GenAI', 'Digital GenAI', '2025-08-01', NULL, 'Trabalhei colaborando com o código do projeto MyNumerologyMap, tanto para o frontend quanto para o backend, sendo responsável por implementações de checkout e integração com provedores de pagamento online.', 'I worked collaborating on the MyNumerologyMap project code, for both frontend and backend, being responsible for checkout implementations and integration with online payment providers.', 'Trabajé colaborando con el código del proyecto MyNumerologyMap, tanto para el frontend como para el backend, siendo responsable de las implementaciones de checkout e integración con proveedores de pago online.'),
('Jr Full Stack Web Developer', 'Jr Full Stack Web Developer', 'Desarrollador Jr Full Stack Web', 'Inifite Gold', '2025-07-01', '2025-07-31', 'Trabalhei colaborando com o código do projeto MyNumerologyMap, tanto para o frontend quanto para o backend, sendo responsável por implementações de checkout e integração com provedores de pagamento online.', 'I worked collaborating on the MyNumerologyMap project code, for both frontend and backend, being responsible for checkout implementations and integration with online payment providers.', 'Trabajé colaborando con el código del proyecto MyNumerologyMap, tanto para el frontend como para el backend, siendo responsable de las implementaciones de checkout e integración con proveedores de pago online.'),
('Analista de Suporte a Sistemas', 'Systems Support Analyst', 'Analista de Soporte a Sistemas', 'Accenture', '2022-02-01', '2024-02-29', 'Fui responsável pela gestão de acesso das equipes e dos clientes a sistemas internos de gestão de vulnerabilidades, SOAR e cyber resilience, sendo que alguns destes possuíam por volta de uma centena de milhar de ativos registrados. Também propunha melhorias e alterações para nossos sistemas, realizava a frente de contato com os clientes e também atuava como ticket manager.', 'I was responsible for managing team and client access to internal vulnerability management, SOAR, and cyber resilience systems, some of which had around a hundred thousand registered assets. I also proposed improvements and changes to our systems, handled client communication, and acted as ticket manager.', 'Fui responsable de la gestión de acceso de los equipos y clientes a sistemas internos de gestión de vulnerabilidades, SOAR y cyber resilience, siendo que algunos de estos tenían alrededor de un centenar de miles de activos registrados. También proponía mejoras y cambios para nuestros sistemas, realizaba el contacto con los clientes y también actuaba como ticket manager.'),
('Ticket Manager', 'Ticket Manager', 'Ticket Manager', 'Morphus Segurança da Informação', '2021-01-01', '2022-02-28', 'Atuei como ponto focal de contato com os clientes externos e internos, realizando a resolução de demandas que estavam em meu escopo e escalonando as que não estavam. Também gerava relatórios com o Power BI e ministrava treinamentos para o acesso à ferramenta de ITSM utilizada internamente.', 'I acted as the focal point of contact with external and internal clients, resolving demands within my scope and escalating those that weren''t. I also generated reports with Power BI and conducted training sessions for accessing the ITSM tool used internally.', 'Actué como punto focal de contacto con los clientes externos e internos, realizando la resolución de demandas que estaban en mi alcance y escalando las que no lo estaban. También generaba informes con Power BI y impartía capacitaciones para el acceso a la herramienta de ITSM utilizada internamente.'),
('Ticket Manager', 'Ticket Manager', 'Ticket Manager', 'Dongkuk Systems', '2020-02-01', '2020-12-31', 'Atuei como ponto focal de contato com os clientes externos, realizando a resolução de demandas que estavam em meu escopo e escalonando as que não estavam. Também gerava relatórios com o Excel de chamados atendidos e escalados.', 'I acted as the focal point of contact with external clients, resolving demands within my scope and escalating those that weren''t. I also generated Excel reports of attended and escalated tickets.', 'Actué como punto focal de contacto con los clientes externos, realizando la resolución de demandas que estaban en mi alcance y escalando las que no lo estaban. También generaba informes con Excel de tickets atendidos y escalados.'),
('Estagiário em TI', 'IT Intern', 'Pasante en TI', 'Grupo Edson Queiroz', '2019-05-01', '2020-02-29', 'Atuei como ponto focal de contato com os clientes internos do Grupo, realizando a resolução de demandas que estavam em meu escopo e escalonando as que não estavam. Também atuei como suporte técnico, oferecendo manutenção e assistência local.', 'I acted as the focal point of contact with the Group''s internal clients, resolving demands within my scope and escalating those that weren''t. I also worked as technical support, providing maintenance and local assistance.', 'Actué como punto focal de contacto con los clientes internos del Grupo, realizando la resolución de demandas que estaban en mi alcance y escalando las que no lo estaban. También actué como soporte técnico, ofreciendo mantenimiento y asistencia local.');

INSERT INTO "Hardskills" ("NomeHardskill", "Nivel")
VALUES 
('Desenvolvimento Web', 8),
('HTML, CSS, Javascript', 8),
('React.js / Node.js / Express', 7),
('Python / Django', 7),
('Git / GitHub', 8),
('SQL / MySQL / PostgreSQL', 7),
('Linux Bash', 6),
('C# / .NET', 7),        
('RESTful API', 8),      
('Docker', 7);           

INSERT INTO "Softskills" ("NomeSoftskill", "NomeSoftskillEn", "NomeSoftskillEs", "Nivel")
VALUES 
('Desenvolvimento Ágil', 'Agile Development', 'Desarrollo Ágil', 8),
('Scrum / Kanban', 'Scrum / Kanban', 'Scrum / Kanban', 8),
('Resolução de Problemas', 'Problem Solving', 'Resolución de Problemas', 9),
('Resiliência', 'Resilience', 'Resiliencia', 9),
('Trabalho em Equipe', 'Teamwork', 'Trabajo en Equipo', 9),
('Foco em Resultados', 'Results Oriented', 'Enfoque en Resultados', 8);

INSERT INTO "Curiosidades" ("Descricao", "DescricaoEn", "DescricaoEs")
VALUES 
('Sou canhoto', 'I''m left-handed', 'Soy zurdo'),
('Tenho uma guitarra própria para canhotos', 'I have my own left-handed guitar', 'Tengo una guitarra propia para zurdos'),
('Já ganhei uma competição de karate quando era criança, mas perdi a medalha', 'I won a karate competition as a child, but lost the medal', 'Gané una competencia de karate cuando era niño, pero perdí la medalla'),
('Já fui Top 3 em dano causado e Top 8 em velocidade de conclusão dos tanks do servidor Norte-Americano (Primal) no Final Fantasy XIV, na expansão Endwalker', 'I was Top 3 in damage and Top 8 in tank clear speed on the North American server (Primal) in Final Fantasy XIV during the Endwalker expansion', 'Fui Top 3 en daño causado y Top 8 en velocidad de finalización de los tanks del servidor Norteamericano (Primal) en Final Fantasy XIV, en la expansión Endwalker'),
('Também já fui Top 25 de Ryan em PvP no saudoso Grand Chase', 'I was also Top 25 Ryan in PvP in the beloved Grand Chase', 'También fui Top 25 de Ryan en PvP en el querido Grand Chase'),
('Amo jogos de luta, inclusive tenho um controle arcade pra jogar Street Fighter 6 e Tekken 8', 'I love fighting games, I even have an arcade controller to play Street Fighter 6 and Tekken 8', 'Amo los juegos de lucha, incluso tengo un control arcade para jugar Street Fighter 6 y Tekken 8'),
('Meu sonho é ser desenvolvedor de jogos e pretendo fazer um jogo por conta própria e upar na Steam. Já possuo dois jogos no currículo.', 'My dream is to be a game developer and I plan to make a game on my own and upload it to Steam. I already have two games under my belt.', 'Mi sueño es ser desarrollador de juegos y planeo hacer un juego por mi cuenta y subirlo a Steam. Ya tengo dos juegos en mi currículum.'),
('Tenho um Canal na Twitch, mas como o Pc não aguenta mais fazer lives, tá em hiato por um tempo', 'I have a Twitch Channel, but since my PC can''t handle streaming anymore, it''s on hiatus for a while', 'Tengo un Canal en Twitch, pero como la PC ya no soporta hacer lives, está en pausa por un tiempo');