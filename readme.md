# TCP_Server & TCP_Client

## Jak uruchomi�

1. Sklonuj repo
2. Uruchom TCP_Server.sln w Visual Studio
3. Skompiluj projekt

## Jak przetestowa�

Do poprawnego dzia�ania jak i przetestowania wymagane jest u�ycie obu program�w. 

1. Uruchom TCP_Server (port zostanie wygenerowany losowo)
2. Wpisz numer IP  (domy�lnie ustawiony jest 0.0.0.0)
3. Wpisz wiadomo�� w polu "Message" (domy�lnie jest test)
4. Wci�nij przycisk Start
5. Uruchom TCP_Client
6. Wpisz adres IP serwera ( adres IP komputera w tej samej sieci lokalnej lub adres lokalny 127.0.0.1 w przypadku uruchomienia obu program�w na jednym komputerze)
7. Wpisz port identyczny z tym wygenerowanym w serwerze
8. Wci�nij przycisk Connect
9. Je�li po��czenie zosta�o nawi�zane w kliencie powinna wy�wietli� si� wiadomo�� ustawiona na serwerze. 


## TODO - Pomys�y na rozw�j projektu

1. Zaimplementowa� mo�liwo�� nawi�zywania wielu po��cze�.