import { TeamsTheme } from './theme';

/**
 * Implementation of the Silverstone content page
 */
export class silverstoneTab {
    /**
     * Constructor for silverstone that initializes the Microsoft Teams script and themes management
     */
    constructor() {
        microsoftTeams.initialize();
        TeamsTheme.fix();
    }
    /**
     * Method to invoke on page to start processing
     * Add your custom implementation here
     */
    public doStuff() {
        microsoftTeams.getContext((context: microsoftTeams.Context) => {
            let element = document.getElementById('app');
            if (element) {
                element.innerHTML = `<h2>${context.entityId}</h2>`;
            }
        });
    }
}