import { NavigationItem } from "./NavigationItem";
import { Player } from "@/player/Player";

export class NavigationProvider {
    navigationItems : NavigationItem[] = [];

    async fetch(authenticated: boolean, player: Player) {
        this.navigationItems = [];
        this.navigationItems.push(new NavigationItem("Home", "mdi-beehive-outline", "/"));

        if(authenticated)
        {
          this.navigationItems.push(new NavigationItem(player.nickname,"mdi-account-cowboy-hat","player"));
        } 
        
        this.navigationItems.push(new NavigationItem("Spells","mdi-billiards","will"));
        this.navigationItems.push(new NavigationItem("About","mdi-battery-unknown","about"));
      }
}