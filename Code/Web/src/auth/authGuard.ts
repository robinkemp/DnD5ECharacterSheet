import { getInstance } from "../auth";
import { NavigationGuard } from "vue-router";
import { PlayerProvider } from "@/player/PlayerProvider";

export const authGuard: NavigationGuard = (to, from, next) => {
  const authService = getInstance();

  let unwatch = () => { return; };

  const fn = async () => {
    // Unwatch loading
    unwatch && unwatch();

    // If the user is authenticated, continue with the route
    if (authService.isAuthenticated) {
      const user = await authService.getUser();
      const playerProvider = new PlayerProvider();
      const player = await playerProvider.fetchFromSub(user.sub); 
      if(player.id === ""){
        return next({ path: "/register" });
      }

      return next();
    }

    // Otherwise, log in
    authService.loginWithRedirect({ appState: { targetUrl: to.fullPath } });
  };

  // If loading has already finished, check our auth state using `fn()`
  if (!authService.loading) {
    return fn();
  }

  // Watch for the loading property to change before we check isAuthenticated
  unwatch = authService.$watch("loading", (loading: boolean) => {
    if (loading === false) {
      return fn();
    }
  });
};
