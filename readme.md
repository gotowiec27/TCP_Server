# TCP_Server & TCP_Client

## Jak uruchomiæ

1. Sklonuj repo
2. Uruchom TCP_Server.sln w Visual Studio
3. Skompiluj projekt

## Jak przetestowaæ

Do poprawnego dzia³ania jak i przetestowania wymagane jest u¿ycie obu programów. 

1. Uruchom TCP_Server (port zostanie wygenerowany losowo)
2. Wpisz numer IP  (domyœlnie ustawiony jest 0.0.0.0)
3. Wpisz wiadomoœæ w polu "Message" (domyœlnie jest test)
4. Wciœnij przycisk Start
5. Uruchom TCP_Client
6. Wpisz adres IP serwera ( adres IP komputera w tej samej sieci lokalnej lub adres lokalny 127.0.0.1 w przypadku uruchomienia obu programów na jednym komputerze)
7. Wpisz port identyczny z tym wygenerowanym w serwerze
8. Wciœnij przycisk Connect
9. Jeœli po³¹czenie zosta³o nawi¹zane w kliencie powinna wyœwietliæ siê wiadomoœæ ustawiona na serwerze. 


## TODO - Pomys³y na rozwój projektu

1. Zaimplementowaæ mo¿liwoœæ nawi¹zywania wielu po³¹czeñ.