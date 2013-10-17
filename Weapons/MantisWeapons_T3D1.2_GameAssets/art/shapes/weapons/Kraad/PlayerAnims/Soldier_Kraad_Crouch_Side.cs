singleton TSShapeConstructor(Soldier_Kraad_Crouch_SideDAE)
{
   baseShape = "./Soldier_Kraad_Crouch_Side.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_Crouch_SideDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Side", "520", "549", true, true);
}
