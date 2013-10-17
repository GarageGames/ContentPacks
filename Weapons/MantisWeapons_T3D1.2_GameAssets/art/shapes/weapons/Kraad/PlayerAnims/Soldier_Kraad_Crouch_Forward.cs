singleton TSShapeConstructor(Soldier_Kraad_Crouch_ForwardDAE)
{
   baseShape = "./Soldier_Kraad_Crouch_Forward.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kraad_Crouch_ForwardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Forward", "400", "429", true, true);
}
