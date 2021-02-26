import { Character } from "./Character";
import Axios from "axios";

export class CharacterListProvider {
  constructor() {
    this.fetchApi();
  }

  characters: Character[] = [];

  fetch() {
    this.characters.push(new Character("1", "Sindri"));
    this.characters.push(new Character("1", "Cloud"));
  }

  async fetchApi(){
    const response = await Axios.get<Character[]>("http://localhost:7071/api/GetCharactersFromMongo");
    this.characters.length == 0;
    if(response.data)
    {
        response.data.forEach(d => 
            this.characters.push(new Character(d.characterId, d.characterName))
        );
    }
  }
}
