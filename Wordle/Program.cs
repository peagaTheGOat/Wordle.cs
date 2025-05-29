﻿using System;
using System.Collections.Generic;

class Termo
{
    static void Main()
    {
        string[] palavras = { "sagaz", "âmago", "termo", "negro", "êxito", "mexer", "nobre", "senso", "afeto", "ética", "algoz", "plena", "fazer", "assim", "tênue", "mútua", "sobre", "aquém", "vigor", "seção", "poder",
        "sutil", "porém", "fosse", "cerne", "ideia", "sanar", "audaz", "moral", "inato", "quiçá", "desde", "muito", "justo", "sonho", "honra", "torpe", "razão", "amigo", "ícone", "etnia", "égide", "fútil", "anexo", "dengo",
        "tange", "haver", "lapso", "então", "expor", "tempo", "boçal", "seara", "hábil", "mútuo", "saber", "casal", "graça", "ávido", "óbice", "xibiu", "dizer", "ardil", "pesar", "estar", "dever", "causa", "sendo", "tenaz",
        "ainda", "pária", "brado", "coser", "crivo", "temor", "genro", "posse", "comum", "ápice", "prole", "ânimo", "assaz", "ceder", "corja", "pauta", "detém", "fugaz", "censo", "ânsia", "culto", "digno", "atroz", "mundo",
        "forte", "vulgo", "mesmo", "vício", "gleba", "saúde", "criar", "cozer", "revés", "todos", "valha", "jeito", "denso", "pudor", "dogma", "neném", "louco", "atrás", "regra", "ordem", "limbo", "feliz", "pedir", "mercê",
        "homem", "clava", "impor", "banal", "usura", "ajuda", "round", "coisa", "juízo", "forma", "sábio", "legal", "servo", "certo", "falar", "prosa", "tenro", "falso", "desse", "presa", "pífio", "posso", "cunho", "herói",
        "devir", "vendo", "viril", "ontem", "fácil", "valor", "visar", "manso", "linda", "meiga", "puder", "sério", "ébrio", "mágoa", "acaso", "guisa", "reaça", "fluir", "afago", "ímpio", "lugar", "platô", "temer", "abrir",
        "garbo", "praxe", "união", "obter", "gerar", "burro", "matiz", "afins", "óbvio", "cisma", "bruma", "pleno", "êxodo", "crise", "vênia", "tédio", "álibi", "fluxo", "senil", "ritmo", "havia", "morte", "levar", "enfim",
        "olhar", "tomar", "casta", "visão", "gênio", "prumo", "brega", "parvo", "ouvir", "cabal", "vital", "reles", "falta", "bravo", "calma", "favor", "parco", "outro", "tecer", "pulha", "vivaz", "reter", "terra", "sábia",
        "tendo", "ameno", "viver", "valia", "laico", "único", "força", "grato", "passo", "noção", "achar", "carma", "nicho", "possa", "rever", "papel", "ranço", "nossa", "pobre", "rogar", "noite", "façam", "prime", "fardo",
        "farsa", "dúbio", "ativo", "coeso", "fator", "épico", "anelo", "óbito", "selar", "claro", "líder", "sinto", "sesta", "leigo", "citar", "cisão", "sonso", "cesta", "deter", "ciúme", "atuar", "vazio", "velho", "gente",
        "haste", "tende", "adiar", "ficar", "revel", "humor", "ideal", "sulco", "fonte", "ponto", "árduo", "marco", "igual", "labor", "vemos", "exato", "feixe", "senão", "remir", "terno", "amplo", "tanto", "lavra", "hiato",
        "capaz", "cauda", "débil", "ciclo", "relva", "inata", "ótica", "jovem", "tenra", "gesto", "varão", "ambos", "chuva", "coçar", "raiva", "pouco", "toada", "caçar", "vácuo", "sonsa", "imune", "apoio", "velar", "série",
        "vimos", "algum", "xeque", "farão", "feito", "horda", "fusão", "carro", "advém", "leito", "entre", "coesa", "sente", "probo", "minha", "cruel", "doido", "trama", "sorte", "frase", "anuir", "lazer", "brisa", "ímpar",
        "verso", "torço", "chata", "rigor", "massa", "botar", "prece", "blasé", "pegar", "maior", "dorso", "seita", "fauna", "signo", "moção", "furor", "preso", "covil", "credo", "livro", "plano", "áurea", "liame", "vetor",
        "casto", "agora", "flora", "morar", "comer", "praia", "ocaso", "senda", "saiba", "adeus", "pecha", "dócil", "nunca", "faina", "peste", "aliás", "houve", "ambas", "árido", "setor", "manha", "ardor", "mudar", "peixe",
        "parte", "vírus", "visse", "rezar", "meses", "antro", "salvo", "risco", "vulto", "pajem", "saída", "beata", "junto", "breve", "vasto", "aceso", "campo", "ótimo", "morro", "avaro", "estão", "grupo", "sinal", "antes",
        "reger", "banzo", "prado", "andar", "áureo", "lenda", "anais", "conta", "segue", "acima", "serão", "opção", "oxalá", "fugir", "chulo", "verbo", "birra", "festa", "leite", "rapaz", "vilão", "motim", "nação", "brava",
        "treta", "texto", "fruir", "parar", "tirar", "índio", "átomo", "fitar", "ídolo", "traga", "jazia", "puxar", "tenso", "reino", "gerir", "prazo", "alude", "filho", "átrio", "tosco", "norma", "prova", "turba", "bônus",
        "exame", "época", "manhã", "corpo", "preto", "voraz", "sarça", "bando", "acesa", "cheio", "malta", "arcar", "aonde", "ligar", "fatos", "sinhá", "nosso", "psico", "anciã", "magia", "cópia", "avião", "quase", "venal",
        "fatal", "certa", "praga", "logro", "dessa", "longe", "quota", "afora", "nível", "fixar", "oásis", "apego", "mente", "pompa", "messe", "sexta", "nódoa", "lidar", "perda", "coito", "alado", "tocar", "sumir", "caixa",
        "parca", "jirau", "apelo", "fraco", "soldo", "verve", "tinha", "livre", "glosa", "vezes", "lindo", "porta", "firme", "grave", "solto", "bater", "cânon", "opaco", "faixa", "astro", "virão", "salve", "sabia", "turva",
        "irmão", "besta", "doído", "trupe", "atual", "fenda", "navio", "supra", "elite", "grata", "deixa", "exijo", "pardo", "alçar", "autor", "parva", "junco", "pique", "curso", "cioso", "viria", "bicho", "douto", "macio",
        "bioma", "desta", "ético", "pagão", "reses", "ficha", "aluno", "cousa", "chato", "calda", "posto", "abuso", "menos", "rádio", "caber", "judeu", "vídeo", "locus", "culpa", "supor", "verba", "super", "zelar", "drops",
        "lápis", "gosto", "suave", "retém", "calão", "extra", "privê", "advir", "molho", "agudo", "torso", "júlia", "baixo", "vosso", "vinha", "facho", "peito", "turma", "ígneo", "pódio", "ruína", "passa", "sítio", "light",
        "asilo", "combo", "órfão", "traço", "piada", "ávida", "estio", "turvo", "louça", "pilar", "chama", "forem", "ações", "pisar", "refém", "mosto", "amena", "mesma", "páreo", "poeta", "brabo", "ereto", "acolá", "museu",
        "finda", "metiê", "meigo", "local", "lasso", "medir", "optar", "busca", "surja", "teste", "facto", "poema", "tento", "drama", "autos", "cútis", "coral", "rouca", "rumor", "folga", "clima", "aviso", "geral", "paira",
        "cocho", "hobby", "amiga", "calmo", "pedra", "boato", "idoso", "urgia", "cetro", "feroz", "tacha", "feudo", "rubro", "pacto", "volta", "clean", "monge", "móvel", "crime", "ateia", "açude", "lição", "golpe", "daqui",
        "tetra", "ponha", "artur", "riste", "corso", "carta", "ecoar", "bença", "natal", "ébano", "casar", "manga", "monte", "plumo", "falha", "cacho", "verde", "vigia", "aroma", "saldo", "itens", "fazia", "conto", "briga",
        "hoste", "tribo", "grama", "escol", "pasmo", "vetar", "mangá", "tarde", "fórum", "letal", "única", "rival", "amada", "chefe", "troça", "súcia", "sósia", "pedro", "vento", "civil", "roupa", "fruto", "ornar", "venha",
        "penta", "úteis", "plaga", "plebe", "nuvem", "sarau", "swing", "órgão", "pinho", "areia", "tchau", "átimo", "cover", "cargo", "lesse", "nesse", "virar", "jogar", "vazão", "berro", "jejum", "macro", "arado", "stand",
        "finjo", "axila", "seixo", "magna", "fosso", "catre", "perto", "farta", "rocha", "gíria", "tiver", "beijo", "mídia", "varoa", "troca", "légua", "inter", "tição", "bruta", "bruto", "todas", "tutor", "deste", "calor",
        "traje", "renda", "close", "trato", "gabar", "assar", "pomar", "perco", "viram", "guria", "porte", "tenha", "amado", "surto", "estro", "nessa", "vadio", "arfar", "santo", "dança", "rural", "feita", "âmbar", "verão",
        "nesta", "silvo", "canso", "xucro", "odiar", "depor", "fossa", "vista", "mamãe", "logos", "bazar", "vedar", "laudo", "recém", "aviar", "grota", "pavor", "canto", "etapa", "cheia", "marca", "negar", "irado", "chula",
        "bolsa", "cenho", "cifra", "cerca", "salmo", "densa", "clero", "minar", "ferpa", "cinto", "visto", "ágape", "régio", "bucho", "coroa", "vagar", "sofia", "burra", "molde", "horto", "urdir", "invés", "segar", "letra",
        "ruído", "lesão", "largo", "proto", "quais", "folha", "paiol", "sótão", "símio", "velha", "esgar", "penso", "jazer", "pugna", "morfo", "final", "trago", "deram", "úbere", "fundo", "pasma", "lesto", "narco", "vasta",
        "ceita", "ufano", "queda", "troco", "ardis", "olhos", "álamo", "podar", "troço", "linha", "piche", "apear", "viger", "úmido", "frota", "folia", "pólis", "bulir", "mocho", "preço", "neste", "ileso", "áudio", "peita",
        "outra", "resto", "disso", "manto", "matar", "farol", "redor", "cosmo", "monta", "seiva", "chave", "cível", "bolso", "chaga", "barro", "mover", "misto", "lábia", "falsa", "retro", "limpo", "logia", "vazia", "nácar",
        "louca", "nariz", "veloz", "justa", "campa", "banto", "barão", "álbum", "lutar", "louro", "bedel", "macho", "mimar", "sabor", "punha", "gemer", "porca", "axial", "toque", "samba", "arroz", "zumbi", "lucro", "dados",
        "longo", "coevo", "enjoo", "calça", "calvo", "venho", "findo", "salva", "rente", "subir", "farto", "urgir", "diabo", "baixa", "lousa", "pagar", "firma", "solta", "sabiá", "xampu", "pluma", "ousar", "fazes", "bruxa",
        "valer", "torna", "sexto", "forro", "repor", "sigla", "fátuo", "reler", "sacar", "fugiu", "gueto", "choça", "demão", "lento", "canil", "cardo", "bugre", "hífen", "pular", "corar", "vário", "corte", "focar", "custo",
        "míope", "voilà", "mania", "feira", "rácio", "versa", "nesga", "sadio", "ferir", "modal", "tumba", "sócio", "harém", "penca", "sugar", "digna", "ceifa", "puído", "pátio" };
        Random rnd = new Random();
        string palavraSecreta = palavras[rnd.Next(palavras.Length)];
        int tentativasRestantes = 6;

        Console.WriteLine("Tente adivinhar a palavra de 5 letras. Você tem 6 tentativas.\n");

        while (tentativasRestantes > 0)
        {
            Console.Write($"Tentativa ({7 - tentativasRestantes}/6): ");
            string tentativa = Console.ReadLine().ToLower();

            if (tentativa.Length != 5)
            {
                Console.WriteLine(" 5 letras seu burro");
                continue;
            }

            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < 5; i++)
            {
                char letra = tentativa[i];
                if (letra == palavraSecreta[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green; // Letra certa no lugar certo
                }
                else if (palavraSecreta.Contains(letra))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow; // Letra certa no lugar errado
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray; // Letra errada
                }

                Console.Write(letra);
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine();

            if (tentativa == palavraSecreta)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n GG");
                Console.ResetColor();
                return;
            }

            tentativasRestantes--;
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n Aiai ce sabeeeee, a palavra era: {palavraSecreta}");
        Console.ResetColor();
    }
}
