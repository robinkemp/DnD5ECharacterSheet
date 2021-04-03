<template>
  <v-card class="mx-auto" max-width="400" tile>
    <v-list>
      <v-list-item v-for="(item, i) in provider.characters" :key="i">
        <v-list-item-content>
          <v-list-item-title v-text="item.characterName"></v-list-item-title>
        </v-list-item-content>
      </v-list-item>
    </v-list>
  </v-card>
</template>

<script lang="ts">
import { Vue, Component } from "vue-property-decorator";
import { CharacterListProvider } from "@/character/CharacterListProvider";

@Component({ components: {} })
export default class CharacterList extends Vue {
  provider = new CharacterListProvider();
}
</script>
