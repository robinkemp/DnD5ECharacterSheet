import { Character } from "./Character";
export class CharacterListProvider {
  constructor() {
    this.fetch();
  }

  characters: Character[] = [];

  fetch() {
    this.characters.push(new Character("1", "Sindri"));
    this.characters.push(new Character("1", "Cloud"));
  }
}
