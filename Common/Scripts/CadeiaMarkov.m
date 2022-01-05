function [mc, X] = CadeiaMarkov(matriz, estados, iteracoes)
    mc = dtmc(matriz,'StateNames',estados);
	X = redistribute(mc,iteracoes);
end