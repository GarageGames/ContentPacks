singleton TSShapeConstructor(Soldier_Kralmok_Crouch_RootDAE)
{
   baseShape = "./Soldier_Kralmok_Crouch_Root.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kralmok_Crouch_RootDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Root", "290", "349", true, true);
}
