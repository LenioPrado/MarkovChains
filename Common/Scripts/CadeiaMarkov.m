function [matriz_transicao, simulacao, dist_uniforme, dist_estacionaria] = CadeiaMarkov(matriz, estados, iteracoes, estado_inicial)
    mc = dtmc(matriz,'StateNames',estados);
	
	x0 = [0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0];
	x0(estado_inicial) = iteracoes;
	
	dist_uniforme = redistribute(mc,iteracoes, 'X0', x0);
	
	simulacao = simulate(mc,iteracoes, 'X0', x0);
		
	dist_estacionaria = asymptotics(mc);
	
	matriz_transicao = mc.P;
end