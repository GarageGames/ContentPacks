singleton TSShapeConstructor(Soldier_Kral_Crouch_RootDAE)
{
   baseShape = "./Soldier_Kral_Crouch_Root.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kral_Crouch_RootDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Root", "300", "359", true, true);
}
