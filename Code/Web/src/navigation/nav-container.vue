<template>
  <v-navigation-drawer
    absolute
    permanent
    right
    expand-on-hover>
    <v-list
      dense
      nav>
      <v-list-item
        v-for="item in this.navigationProvider.navigationItems"
        :key="item.title"
        :to="item.route"
        link>
        <v-list-item-icon>
          <v-icon>{{ item.icon }}</v-icon>
        </v-list-item-icon>
        <v-list-item-content>
          <v-list-item-title>{{ item.title }}</v-list-item-title>
        </v-list-item-content>
      </v-list-item>
    </v-list>
  </v-navigation-drawer>
</template>

<script lang="ts">
import { Vue, Prop, Component, Watch } from "vue-property-decorator";
import { NavigationProvider } from "@/navigation/NavigationProvider";
import { Player } from "@/player/Player";

@Component({})
export default class NavContainer extends Vue {
  @Prop() authenticated!: boolean;
  @Prop() player!: Player;

  navigationProvider: NavigationProvider = new NavigationProvider();

  async created(): Promise<void> {
    await this.fetchNavigation();
  }

  @Watch("authenticated")
  async authenticatedChanged(): Promise<void> {
      await this.fetchNavigation();
  }
  
  @Watch("player")
  async playerChanged(): Promise<void> {
      await this.fetchNavigation();
  }

  async fetchNavigation() {
    await this.navigationProvider.fetch(this.authenticated, this.player);
  }
 
}
</script>