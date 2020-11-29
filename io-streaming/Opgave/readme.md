# Brug af StreamWriter

I denne opgave skal du skrive 100.000 Guids (```System.Guid.NewGuid().ToString()```) til en fil på disken. 

Du kunne vælge først at danne en string og gemme denne men ved mange poster bliver det hurtigt for tungt.
Så i denne opgave skal du åbne en ```System.IO.StreamWriter``` med ```System.IO.File.OpenWrite(sti)``` og benytte
instansen af StreamWriter's WriteLine-metode.

Se min løsning [her](https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/io-streaming/Program.cs).
