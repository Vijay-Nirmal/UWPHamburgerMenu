# UWPHamburgerMenu

UWP Hamburger Menu with Frosted glass effect and Swipe to Open/Close

I used [UWPCommunityToolkit](http://www.uwpcommunitytoolkit.com/en/master/) to blur.

    <interactivity:Interaction.Behaviors>
        <behaviors:Blur x:Name="BlurBehavior" 
               Value="25" 
               Duration="0" 
               Delay="0" 
               AutomaticallyStart="True"/>
    </interactivity:Interaction.Behaviors>
    
If you want to increase or decrease the amount of blur then change the value in behaviors

**To swipe to open the hamburger menu**

    private void SplitViewPane_ManipulationCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
    {
            if (e.Cumulative.Translation.X < -50)
            {
                HamburgerMenu.IsPaneOpen = false;
            }

            if (e.Cumulative.Translation.X > 50)
            {
                HamburgerMenu.IsPaneOpen = true;
            }
    }

    private void SplitViewOpener_ManipulationCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
    {
            if (e.Cumulative.Translation.X > 50)
            {
                HamburgerMenu.IsPaneOpen = true;
            }
    }

    //This Grid should be inside SplitView.Pane
    <Grid Name="PaneGrid" Background="Transparent" ManipulationMode="TranslateX" ManipulationCompleted="SplitViewPane_ManipulationCompleted">

    //This Grid should be inside SplitView.Content
    <Grid ManipulationMode="TranslateX" ManipulationCompleted="SplitViewOpener_ManipulationCompleted" Width="50" Background="Transparent" HorizontalAlignment="Left" VerticalAlignment="Stretch"/>

By Vijay Nirmal

https://twitter.com/_Vijay_Nirmal_

https://www.linkedin.com/in/vijay-nirmal
