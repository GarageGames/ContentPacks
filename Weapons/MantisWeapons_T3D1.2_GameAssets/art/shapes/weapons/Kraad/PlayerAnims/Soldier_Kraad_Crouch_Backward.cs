singleton TSShapeConstructor(Soldier_Kraad_Crouch_BackwardDAE)
{
   baseShape = "./Soldier_Kraad_Crouch_Backward.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_Crouch_BackwardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Backward", "460", "489", true, true);
}
