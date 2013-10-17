singleton TSShapeConstructor(Soldier_Kraad_Crouch_RootDAE)
{
   baseShape = "./Soldier_Kraad_Crouch_Root.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_Crouch_RootDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Root", "300", "359", true, true);
}
