# .Net

Lab2 - Kata04 Questions
To what extent did the design decisions you made when writing the original programs make it easier or harder to factor out common code?
Faptul ca implementarea solutiei initiale era specifica pentru rezolvarea punctuala a problemei a facut ca extinderea solutiei sa fie mai dificila, nefiind deschisa generalizarii.

Was the way you wrote the second program influenced by writing the first?
Am refolosit o parte din codul scris, dar am abordat o rezolvare diferita, incercand sa pastrez coeziunea mare si cuplarea mica.

Is factoring out as much common code as possible always a good thing? Did the readability of the programs suffer because of this requirement? How about the maintainability?
Consider ca daca solutia poate fi aplicata pentru rezolvarea mai multor probleme similare, timpul petrecut pentru refactoring sau generalizarea solutiei se justifica si este necesar.
In urma refactorizarii solutia a devenit mai usor de citit si inteles, atat datorita genericitatii cat is a naming-ului, iar de asemenea este si mult mai usor de intretinut, fiind deschisa pentru extindere.
