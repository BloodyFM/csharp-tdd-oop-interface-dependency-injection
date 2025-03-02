﻿namespace tdd_oop_interface_dependency_injection.CSharp.Main;

public class Scrabble {
    private Dictionary<Char, int> letterScores;

    public Scrabble(IAlphabet alphabet) {
        this.letterScores = alphabet.getLetterScores();
    }

    public int score(String word) {
        int total = 0;

        foreach (char ch in word.ToCharArray()) {
            if (this.letterScores.ContainsKey(ch)) {
                int score = this.letterScores[ch];
                total += score;
            }
        }

        return total;
    }
}
