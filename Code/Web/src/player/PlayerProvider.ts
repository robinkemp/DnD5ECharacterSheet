import { Player } from "./Player";
import Axios from "axios";
import { Result } from "@/common/Result";

export class PlayerProvider {

  async fetchFromSub(sub: string): Promise<Player> {
    const response = await Axios.get<Result<Player>>(
      "http://localhost:7071/api/GetPlayerFromSub?sub=" + sub
    );
    
    if (response.data) {
        if (response.data.IsSuccess) {
            return response.data.Value;
        }
    }
    return new Player("","",""); // can we do player.none?
  }

  async registerPlayer(player: Player) : Promise<Player> {
    const response = await Axios.post<Result<Player>>(
      "http://localhost:7071/api/RegisterPlayer",
      player
    );
    if(response.data){
      if (response.data.IsSuccess) {
        return response.data.Value;
      }
    }

    return new Player("","","");
  }
}