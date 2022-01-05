ScriptsPath = @ScriptsPath;
addpath(ScriptsPath);

matriz = @matriz;				
estados = @estados;
iteracoes = @iteracoes;

[mc, X] = CadeiaMarkov(matriz, estados, iteracoes)